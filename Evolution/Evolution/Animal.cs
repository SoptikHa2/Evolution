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
        public string name;
        public int x, y;
        public int energy;
        public Node startNode;
        private MapGeneration.Map map;

        public Animal(string name, MapGeneration.Map map, int x, int y)
        {
            this.name = name;
            this.x = x;
            this.y = y;
            this.map = map;
            GenerateNodes();
        }

        public void GenerateNodes()
        {
            startNode = new IfNode(this);
            Node const0Node = new ConstantNode(0, this);
            Node getNearestFoodNode = new FoodNode(this);
            Node goNode = new GoNode(this);
            Node eatNode = new EatNode(this);
            Node getDirectionNode = new FoodNode(this);

            startNode.children[0] = const0Node;
            startNode.children[1] = getNearestFoodNode;
            startNode.children[2] = eatNode;
            startNode.children[3] = goNode;

            goNode.children[0] = getDirectionNode;
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
