using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution.Evolution.Nodes
{
    [Serializable]
    class TerrainNode : Node
    {
        public TerrainNode(Animal parentAnimal)
        {
            identifier = "TerrainNode";
            minimumChildren = 1;
            maximumChildren = 1;

            children = new Node[maximumChildren];
            this.parentAnimal = parentAnimal;
        }

        public override int Eval()
        {
            if (children[0] == null)
                return -1;
            return parentAnimal.GetTerrainType(children[0].Eval());
        }
    }
}
