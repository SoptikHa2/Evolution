using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution.Utilities
{
    static class GraphViz
    {
        private readonly static string path = Path.Combine("graphviz", "dot.exe");

        public static Image GetGraph(string input)
        {
            try
            {
                // Start the dot.exe file with argument -Tpng. Redirect standart input and output
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = path;
                psi.UseShellExecute = false;
                psi.Arguments = "-Tpng";
                psi.RedirectStandardInput = true;
                psi.RedirectStandardOutput = true;
                psi.CreateNoWindow = true;
                Process p = Process.Start(psi);
                p.StandardInput.WriteLine(input);
                p.StandardInput.BaseStream.Close();
                return Image.FromStream(p.StandardOutput.BaseStream);
            }
            catch
            {
                return null;
            }
        }
        public static Image GetGraph(Evolution.Nodes.Node[] Nodes)
        {
            string input = "";
            for (int i = 0; i < Nodes.Length; i++)
                input += Nodes[i].GetNodeGVDeclaration();
            for (int i = 0; i < Nodes.Length; i++)
                input += Nodes[i].GetNodeLinks();

            return GetGraph("digraph \"Animal Preview\" { node [style=\"rounded,filled\",fillcolor=\"#EEEEEE\"]; " + input + " }");
        }
    }
}
