using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution.Evolution.Nodes
{
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
            try
            {
                if (children[0].Eval() > children[1].Eval())
                    return children[2].Eval();
                return children[3].Eval();
            }
            catch
            {
                return 0;
            }
        }
    }
}
