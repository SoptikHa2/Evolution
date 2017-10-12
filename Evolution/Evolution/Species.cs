using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution.Evolution
{
    public class Species
    {
        public Animal[] animals;

        public Species()
        {
            // ...
            animals = new Animal[] { new Animal("veverka", 10, 10) };
        }

        public void Tick()
        {
            for (int i = 0; i < animals.Length; i++)
                animals[i].Eval();
            // ...
        }
    }
}
