using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution.Evolution
{
    public class Animal
    {
        public string name;
        public int x, y;

        public Animal(string name, int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        private bool increase = true;
        public void Eval()
        {
            // TODO

            if (increase)
                x++;
            else
                x--;
            if (x > 80)
                increase = false;
            else if (x < 20)
                increase = true;
        }
    }
}
