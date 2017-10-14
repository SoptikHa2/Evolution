using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution.Evolution.Nodes
{
    class GoNode : Node
    {
        public int value;

        public GoNode(Animal parentAnimal)
        {
            identifier = "GoNode";
            minimumChildren = 1;
            maximumChildren = 1;

            children = new Node[maximumChildren];
            this.parentAnimal = parentAnimal;
        }

        public override int Eval()
        {
            try
            {
                return parentAnimal.Go(children[0].Eval());
            }
            catch
            {
                return 0;
            }
        }
    }
}
