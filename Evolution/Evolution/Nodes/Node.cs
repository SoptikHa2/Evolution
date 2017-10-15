using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution.Evolution.Nodes
{
    [Serializable]
    public abstract class Node
    {
        public string identifier { get; protected set; } = "Basic Node";
        public int minimumChildren { get; protected set; }
        public int maximumChildren { get; protected set; }
        public Node[] children;
        public Animal parentAnimal;

        public abstract int Eval();
        public override string ToString()
        {
            string s = identifier + "(";
            foreach (Node n in children)
            {
                s += n?.ToString();
            }
            return s + ")";
        }
    }
}
