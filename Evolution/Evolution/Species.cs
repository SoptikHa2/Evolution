using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution.Evolution
{
    [Serializable]
    public class Species
    {
        public Animal[] animals;
        public string speciesColor;
        public string name;

        public Species(string name, MapGeneration.Map map, string speciesColor)
        {
            this.name = name;
            animals = new Animal[] { new Animal(name + "1", map, 10, 10), new Animal(name + "2", map, 20, 20), new Animal(name + "3", map, 30, 30), new Animal(name + "4", map, 40, 40), new Animal(name + "5", map, 50, 50) };
            this.speciesColor = speciesColor;
        }

        public void Tick()
        {
            for (int i = 0; i < animals.Length; i++)
                animals[i].Eval();
        }

        public void NewGeneration()
        {

        }
    }
}
