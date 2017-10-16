using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evolution.Evolution.Nodes;

namespace Evolution.Evolution
{
    [Serializable]
    public class Animal
    {
        #region Settings
        const int startDepth = 3;
        #endregion

        public string name;
        public int x, y;
        public int energy;
        public Node startNode;
        private MapGeneration.Map map;

        private static Random rnd = new Random();

        public Animal(string name, MapGeneration.Map map, int x, int y)
        {
            this.name = name;
            this.x = x;
            this.y = y;
            this.map = map;
            GenerateNodes(startDepth);
        }

        private void GenerateNodes(int depth)
        {
            startNode = RandomNode(false);
            AppendNodesTo(startNode, depth);
        }

        private void AppendNodesTo(Node node, int maxDepth, int currDepth = 0)
        {
            int cd = currDepth;
            if (cd++ < maxDepth)
            {
                int children = node.maximumChildren;
                for (int i = 0; i < children; i++)
                {
                    node.children[i] = RandomNode(cd + 1 == maxDepth);
                    if (node.children[i].maximumChildren > 0)
                        AppendNodesTo(node.children[i], maxDepth, cd);
                }
            }
        }

        private Node RandomNode(bool allowNoChildNodes)
        {
            int rand = rnd.Next(allowNoChildNodes ? 0 : 3, 5);

            switch (rand)
            {
                case 0:
                    return new ConstantNode(rnd.Next(ConstantNode.minValue, ConstantNode.maxValue + 1), this);
                case 1:
                    return new EatNode(this);
                case 2:
                    return new FoodNode(this);
                case 3:
                    return new GoNode(this);
                case 4:
                    return new IfNode(this);
                default:
                    throw new Exception("Node type selected by random number does not exist.");
            }
        }

        public void Eval()
        {
            startNode.Eval();
        }

        public int Go(int direction)
        {
            int dX = 0;
            int dY = 0;

            switch (direction)
            {
                case 0:
                    dX = 1;
                    dY = 0;
                    break;
                case 1:
                    dX = 0;
                    dY = 1;
                    break;
                case 2:
                    dX = -1;
                    dY = 0;
                    break;
                case 3:
                    dX = 0;
                    dY = -1;
                    break;
                default:
                    return 0;
            }

            if (x + dX < 0 || y + dY < 0 || x + dX >= map.map.GetLength(0) || y + dY >= map.map.GetLength(0))
                return 0;
            x += dX;
            y += dY;
            return 1;
        }

        public int GetNearestFoodDirection()
        {
            return map.getNearestFoodDirection(x, y);
        }

        public int Eat()
        {
            int food = map.map[x, y].food;
            map.map[x, y].food = 0;
            energy += food;
            return food;
        }

        public Animal BreedWith(Animal partner, MapGeneration.Map map, string newName)
        {
            return BreedNodeTree(partner.startNode, new Animal(newName, map, -1, -1));
        }

        private Animal BreedNodeTree(Node partnerNodeTree, Animal newAnimal)
        {
            Node newTree = Serializer.DeepClone<Node>(startNode) as Node;
            SetNodeOwnership(newTree, newAnimal);

            // Get number of nodes in tree
            int numberOfNodesInTree = GetNumberOfNodes(newTree);
            // Get random number
            int randomNumber = rnd.Next(numberOfNodesInTree);
            // Get random node:
            Node randomlyChosenNode = GetNode(newTree, randomNumber);

            // Select node of same type from 2nd tree
            Node randomlyChosenSecondTreeNode = null;
            List<Node> sameTypeNodes = GetNodesOfType(partnerNodeTree, randomlyChosenNode.GetType());
            if (sameTypeNodes.Count > 0)
            {
                int random = rnd.Next(sameTypeNodes.Count);
                randomlyChosenSecondTreeNode = sameTypeNodes[random];
            }
            else
            // If not available, select any type from 2nd tree
            {
                int numberOfNodesInSecondTree = GetNumberOfNodes(partnerNodeTree);
                int randomSecondTree = rnd.Next(numberOfNodesInSecondTree);
                randomlyChosenSecondTreeNode = GetNode(partnerNodeTree, randomSecondTree);
            }

            Node nodeFromTree2 = Serializer.DeepClone<Node>(randomlyChosenSecondTreeNode) as Node;
            SetNodeOwnership(nodeFromTree2, newAnimal);
            randomlyChosenNode = randomlyChosenSecondTreeNode;

            newAnimal.startNode = newTree;
            newAnimal.energy = -1;
            return newAnimal;
        }

        private int GetNumberOfNodes(Node tree)
        {
            int c = 1;
            for (int i = 0; i < tree.maximumChildren; i++)
            {
                if (tree.children[i] != null)
                    c += GetNumberOfNodes(tree.children[i]);
            }
            return c;
        }

        private Node GetNode(Node tree, int number, int cnt = 0)
        {
            if (cnt == number)
                return tree;
            else
            {
                Node nToReturn = null;
                for (int i = 0; i < tree.maximumChildren; i++)
                {
                    if (tree.children[i] != null)
                    {
                        nToReturn = GetNode(tree.children[i], number, ++cnt);
                        if (nToReturn != null)
                            return nToReturn;
                        cnt += GetNumberOfNodes(tree.children[i]) - 1;
                    }
                }

                return nToReturn;
            }
        }

        private List<Node> GetNodesOfType(Node tree, Type type)
        {
            List<Node> nodes = new List<Node>();
            if (tree.GetType() == type)
            {
                nodes.Add(tree);
            }
            for (int i = 0; i < tree.maximumChildren; i++)
            {
                if (tree.children[i] != null)
                {
                    nodes.AddRange(GetNodesOfType(tree.children[i], type));
                }
            }
            return nodes;
        }

        private Node CopyNodeTree(Node nodeTree, Animal newAnimal)
        {
            Node copiedTree = Serializer.DeepClone<Node>(nodeTree) as Node;
            SetNodeOwnership(copiedTree, newAnimal);
            return copiedTree;
        }

        private void SetNodeOwnership(Node node, Animal newAnimal)
        {
            node.parentAnimal = newAnimal;
            for (int i = 0; i < node.children.Length; i++)
            {
                if (node.children[i] != null)
                    SetNodeOwnership(node.children[i], newAnimal);
            }
        }

        public override string ToString()
        {
            return $"Animal: {name} at {x};{y}, Energy: {energy}, Nodes: " + Environment.NewLine + startNode.ToString();
        }
    }
}
