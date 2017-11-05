using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution.Evolution.Nodes
{
    [Serializable]
    class HitNode : Node
    {
        public HitNode(Animal parentAnimal)
        {
            identifier = "HitNode";
            minimumChildren = 0;
            maximumChildren = 0;

            children = new Node[maximumChildren];
            this.parentAnimal = parentAnimal;
        }

        public override int Eval()
        {
            return parentAnimal.Fight();
        }
    }
}
