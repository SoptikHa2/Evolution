using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution.Evolution.Nodes
{
    [Serializable]
    class ConstantNode : Node
    {
        public int value;
        public const int minValue = -1;
        public const int maxValue = 3;

        public ConstantNode(int value, Animal parentAnimal)
        {
            identifier = $"ConstantNode ({value})";
            minimumChildren = 0;
            maximumChildren = 0;

            children = new Node[maximumChildren];
            this.value = value;
            this.parentAnimal = parentAnimal;
        }

        public override int Eval()
        {
            return value;
        }
    }
}
