using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution.Evolution.Nodes
{
    class EatNode : Node
    {
        public EatNode(Animal parentAnimal)
        {
            identifier = "EatNode";
            minimumChildren = 0;
            maximumChildren = 0;

            children = new Node[maximumChildren];
            this.parentAnimal = parentAnimal;
        }

        public override int Eval()
        {
            return parentAnimal.Eat();
        }
    }
}
