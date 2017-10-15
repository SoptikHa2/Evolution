using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evolution.Evolution.Nodes;

namespace Evolution.Evolution
{
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
            if(cd++ < maxDepth)
            {
                int children = node.maximumChildren;
                for(int i = 0; i < children; i++)
                {
                    node.children[i] = RandomNode(true);
                    if (node.children[i].maximumChildren > 0)
                        AppendNodesTo(node.children[i], maxDepth, cd);
                }
            }
        }

        private Node RandomNode(bool allowNoChildNodes)
        {
            int rand = rnd.Next(allowNoChildNodes ? 0 : 1, 5);

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
    }
}
