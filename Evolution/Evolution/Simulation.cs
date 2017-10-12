using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution.Evolution
{
    public class Simulation
    {
        // ...
        public void DrawOnBitmap(Graphics graphics)
        {
            graphics.FillRectangle(Brushes.Black, 0, 0, 20, 20);
        }
    }
}
