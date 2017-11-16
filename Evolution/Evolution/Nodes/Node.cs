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
        // Get all links from this label (Node123 -> Node456; Node123 -> Node789; etc) 
        public string GetNodeLinks()
        {
            string s = "";
            for (int i = 0; i < maximumChildren; i++)
            {
                if (children[i] != null)
                    s += $"\"{GetHashCode()}\" -> \"{children[i].GetHashCode()}\";";
            }
            return s;
        }
        // Get this node identifier ("Node123" [label="Go", fillcolor="#AAAAAA"];
        public string GetNodeGVDeclaration()
        {
            return $"\"{GetHashCode()}\" [label=\"{identifier}\", fillcolor=\"#AAAAAA\"";
        }
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
