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

        public Species(string name, MapGeneration.Map map, Brush speciesBrush)
        {
            animals = new Animal[] { new Animal(name, map, 10, 10), new Animal(name, map, 20, 20), new Animal(name, map, 30, 30), new Animal(name, map, 40, 40), new Animal(name, map, 50, 50) };
            this.speciesBrush = speciesBrush;
        }

        public void Tick()
        {
            for (int i = 0; i < animals.Length; i++)
                animals[i].Eval();
        }
    }
}
