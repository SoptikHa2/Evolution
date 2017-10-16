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

        private static Random rnd = new Random();

        public Species(string name, MapGeneration.Map map, string speciesColor, int numberOfAnimals = 50)
        {
            this.name = name;
            animals = new Animal[numberOfAnimals];
            int mapLengthX = map.map.GetLength(0);
            int mapLengthY = map.map.GetLength(1);
            for(int i = 0; i < numberOfAnimals; i++)
            {
                animals[i] = new Animal(name + i, map, rnd.Next(mapLengthX), rnd.Next(mapLengthY));
            }
            this.speciesColor = speciesColor;
        }

        public void Tick()
        {
            for (int i = 0; i < animals.Length; i++)
                animals[i].Eval();
        }

        public void NewGeneration()
        {
            animals = animals.OrderByDescending(x => x.energy).ToArray();
            for(int i = 0; i < animals.Length / 2; i++)
            {
                int partner = rnd.Next(animals.Length);
                animals[i].BreedWith(animals[partner]);
            }
            
        }

        public void ResetAnimals(int maxX, int maxY)
        {
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].energy = 0;
                animals[i].x = rnd.Next(maxX);
                animals[i].y = rnd.Next(maxY);
            }
        }
    }
}
