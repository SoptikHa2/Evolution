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

        public Animal(string name, int x, int y)
        {
            this.x = x;
            this.y = y;
            GenerateNodes();
        }

        public void GenerateNodes()
        {
            // ...

            Node startNode = new IfNode(this);
            Node const0Node = new ConstantNode(0, this);
            Node getNearestFoodNode = new FoodNode(this);
            Node goNode = new GoNode(this);
            Node eatNode = new EatNode(this);
            Node getDirectionNode = new FoodNode(this);

            startNode.children[0] = const0Node;
            startNode.children[1] = getNearestFoodNode;
            startNode.children[2] = goNode;
            startNode.children[3] = eatNode;

            goNode.children[0] = getDirectionNode;
        }

        public void Eval()
        {
            startNode.Eval();
        }

        public int Go(int direction)
        {
            // ...
            if (direction >= 0 && direction < 4)
                // Move
                return 1;

            // Cannot move
            return 0;
        }

        public int GetNearestFoodDirection()
        {
            // If there's food on current tile, return -1, otherwise, return 0-3
            return -1;
        }

        public int Eat()
        {
            // Return quantity of food
            return 0;
        }
    }
}
