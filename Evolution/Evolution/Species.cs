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
        private int animalNumber = 0;

        public Species(string name, MapGeneration.Map map, string speciesColor, int numberOfAnimals = 50)
        {
            this.name = name;
            animals = new Animal[numberOfAnimals];
            int mapLengthX = map.map.GetLength(0);
            int mapLengthY = map.map.GetLength(1);
            for (int i = 0; i < numberOfAnimals; i++)
            {
                animals[i] = new Animal(name + animalNumber++, map, rnd.Next(mapLengthX), rnd.Next(mapLengthY));
            }
            this.speciesColor = speciesColor;
        }

        public void Tick()
        {
            for (int i = 0; i < animals.Length; i++)
                animals[i].Eval();
        }

        public void NewGeneration(MapGeneration.Map map)
        {
            var animals = this.animals.Reverse().ToList();
            int reqCount = animals.Count;

            // Remove all animals with not positive energy
            animals = animals.Where(x => x.energy > 0).ToList();
            int removedAnimalsDueToNegativeEnergy = reqCount - animals.Count;

            if (animals.Count == 0)
                return;

            int removedAnimals = reqCount / 2;
            if (removedAnimalsDueToNegativeEnergy > removedAnimals)
                removedAnimals = removedAnimalsDueToNegativeEnergy;

            // Breed
            List<Animal> newOnes = new List<Animal>();
            while (newOnes.Count < removedAnimals)
            {
                Animal parent1 = null;
                Animal parent2 = null;

                int sum = animals.Select(x => x.energy).Sum();
                int random = rnd.Next(sum);

                for (int i = 0; i < animals.Count; i++)
                {
                    if (random < animals[i].energy)
                    {
                        parent1 = animals[i];
                        break;
                    }
                    random -= animals[i].energy;
                }
                for (int i = 0; i < animals.Count; i++)
                {
                    if (random < animals[i].energy)
                    {
                        parent2 = animals[i];
                        break;
                    }
                    random -= animals[i].energy;
                }
                newOnes.Add(parent1.BreedWith(parent2, map, name + animalNumber++));
            }

            // Remove animals so at most 1/2 of them survives
            animals.RemoveRange(0, removedAnimals - removedAnimalsDueToNegativeEnergy);

            animals.Reverse();
            animals.AddRange(newOnes);
            this.animals = animals.ToArray();
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
