using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution.Evolution
{
    public class Species
    {
        public Animal[] animals;
        public Brush speciesBrush;

        public Species(string name, Brush speciesBrush)
        {
            // ...
            animals = new Animal[] { new Animal(name, 10, 10) };
            this.speciesBrush = speciesBrush;
        }

        public void Tick()
        {
            for (int i = 0; i < animals.Length; i++)
                animals[i].Eval();
            // ...
        }
    }
}
