using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution.Evolution.Nodes
{
    [Serializable]
    class IfNode : Node
    {
        public IfNode(Animal parentAnimal)
        {
            identifier = "IfNode";
            minimumChildren = 4;
            maximumChildren = 4;

            children = new Node[maximumChildren];
            this.parentAnimal = parentAnimal;
        }

        public override int Eval()
        {
            if (children[0] == null || children[1] == null || children[2] == null || children[3] == null)
                return 0;
            if (children[0].Eval() > children[1].Eval())
                return children[2].Eval();
            return children[3].Eval();
        }
    }
}
