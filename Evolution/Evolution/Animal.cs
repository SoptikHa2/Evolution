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
        private const int startDepth = 3;
        private int mutationChance = 5;
        public int startHealth = 20;
        private int attackStrength = 1;
        #endregion

        public string name;
        public Species species;
        public int x = -1;
        public int y = -1;
        public int energy;
        public int health;
        public Node startNode;
        [NonSerialized]
        public Simulation simulation;

        private Random rnd;

        public Animal(string name, Species species, Simulation simulation, int x, int y, int startHealth, int attackStrength, int mutationChance, Random rnd)
        {
            this.name = name;
            this.species = species;
            this.simulation = simulation;
            this.startHealth = startHealth;
            this.attackStrength = attackStrength;
            this.mutationChance = mutationChance;
            this.health = startHealth;
            this.x = x;
            this.y = y;
            this.rnd = rnd;
            GenerateNodes(startDepth);
        }

        public void Eval()
        {
            if (health >= 1)
                startNode.Eval();
        }

        #region BreedMethods
        public Animal BreedWith(Animal partner, MapGeneration.Map map, string newName)
        {
            return BreedNodeTree(partner.startNode, new Animal(newName, species, simulation, -1, -1, startHealth, attackStrength, mutationChance, rnd));
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
            newAnimal.energy = int.MinValue;

            // Mutate nodes
            List<Node> allNodes = GetNodes(newTree);
            // Select nodes to replace
            List<Node> toReplace = new List<Node>();
            for (int i = 0; i < allNodes.Count; i++)
            {
                if (rnd.Next(101) <= mutationChance)
                    toReplace.Add(allNodes[i]);
            }

            for (int i = 0; i < toReplace.Count; i++)
            {
                Node node = toReplace[i];
                MutateNode(newTree, node);
            }

            return newAnimal;
        }

        private void MutateNode(Node tree, Node oldNode)
        {
            Node newNode = RandomNode(oldNode.maximumChildren == 0);
            // Mutate all node children
            for (int i = 0; i < oldNode.maximumChildren; i++)
            {
                if (oldNode.children[i] != null)
                    MutateNode(tree, oldNode.children[i]);
            }
            newNode.children = oldNode.children;
            newNode.parentAnimal = oldNode.parentAnimal;
            ReplaceNode(tree, oldNode, newNode);
        }
        #endregion
        #region TreeMethods
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
            int rand = rnd.Next(allowNoChildNodes ? 0 : 6, 8);

            switch (rand)
            {
                case 0:
                    return new ConstantNode(rnd.Next(ConstantNode.minValue, ConstantNode.maxValue + 1), this);
                case 1:
                    return new EatNode(this);
                case 2:
                    return new FoodNode(this);
                case 3:
                    return new HitRangeNode(this);
                case 4:
                    return new FindEnemyNode(this);
                case 5:
                    return new HitNode(this);
                case 6:
                    return new GoNode(this);
                case 7:
                    return new IfNode(this);
                default:
                    throw new Exception("Node type selected by random number does not exist.");
            }
        }

        private bool ReplaceNode(Node tree, Node oldNode, Node newNode)
        {
            if (tree == oldNode)
            {
                tree = newNode;
                return true;
            }
            else
            {
                for (int i = 0; i < tree.children.Length; i++)
                {
                    if (tree.children[i] != null && ReplaceNode(tree.children[i], oldNode, newNode))
                        return true;
                }
                return false;
            }
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

        public List<Node> GetNodes(Node tree)
        {
            List<Node> nodes = new List<Node>();
            nodes.Add(tree);
            for (int i = 0; i < tree.maximumChildren; i++)
            {
                if (tree.children[i] != null)
                {
                    nodes.AddRange(GetNodes(tree.children[i]));
                }
            }
            return nodes;
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
        #endregion
        #region NodeMethods
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

            if (x + dX < 0 || y + dY < 0 || x + dX >= simulation.map.map.GetLength(0) || y + dY >= simulation.map.map.GetLength(0))
                return 0;

            x += dX;
            y += dY;

            int tile = simulation.map.map[x, y].level;
            if (tile <= Simulation.minSea)
                energy += species.waterMoveEnergy;
            else if (tile >= Simulation.minMountain)
                energy += species.mountainMoveEnergy;
            else
                energy += species.baseMoveEnergy;

            return 1;
        }

        public int GetNearestFoodDirection()
        {
            energy += species.searchFoodEnergy;
            return simulation.map.GetNearestFoodDirection(x, y);
        }

        public int GetNearestEnemyDirection()
        {
            energy += species.searchEnemyEnergy;
            return simulation.map.GetNearestEnemyDirection(x, y, species, simulation);
        }

        /// <summary>
        /// Eat nearest enemy, that is at most 1 tile away. If successfull, return 0, otherwise, return -1
        /// </summary>
        /// <returns></returns>
        public int Fight()
        {
            Animal target = simulation.map.GetNearEnemyAnimal(x, y, species, simulation);
            if (target != null)
            {
                target.health -= attackStrength;
                if (target.health < 1)
                    energy += species.killBonusEnergy;
                energy += species.fightSuccEnergy;
                return 0;
            }
            energy += species.fightEnergy;
            return -1;
        }

        /// <summary>
        /// Get number, that represents, if there is any enemy close enough, so animal can eat him. If nearest enemy is at most 1 tile away, return 0, otherwise, return -1
        /// </summary>
        /// <returns></returns>
        public int IsPossibleToFight()
        {
            energy += species.searchEnemyEnergy;
            return simulation.map.GetNearEnemyAnimal(x, y, species, simulation) == null ? -1 : 0;
        }

        public int Eat()
        {
            int food = simulation.map.map[x, y].food;
            simulation.map.map[x, y].food = 0;
            energy += food * species.foodGainEnergy + species.eatEnergy;
            return food;
        }
        #endregion

        public override string ToString()
        {
            return $"{name}";
        }
    }
}
