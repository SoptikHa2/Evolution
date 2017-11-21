﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution.Evolution.Nodes
{
    [Serializable]
    class GoNode : Node
    {
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
            if (children[0] == null)
                return 0;
            return parentAnimal.Go(children[0].Eval());
        }
    }
}
