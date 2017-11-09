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
        #region Settings
        public int baseMoveEnergy = 0;
        public int waterMoveEnergy = 0;
        public int mountainMoveEnergy = 0;

        public int eatEnergy = 1;
        public int searchFoodEnergy = 0;
        public int searchEnemyEnergy = 0;
        public int fightEnergy = -2;
        public int fightSuccEnergy = 10;
        public int killBonusEnergy = 0;

        public int attackStrength = 1;
        public int maximumHealth = 10;
        #endregion

        public Animal[] animals;
        public string speciesColor;
        public string name;

        private Random rnd;
        private int animalNumber = 0;
        public int maxAnimals;

        public Species(string name, Simulation simulation, string speciesColor, int totalNumberOfSpecies, Random rnd, int attackStrength, int maximumHealth, int mutationChance = 5, int baseMoveEnergy = 0, int waterMoveEnergy = 0, int mountainMoveEnergy = 0, int eatEnergy = 1, int searchFoodEnergy = 0, int searchEnemyEnergy = 0, int fightEnergy = -2, int fightSuccEnergy = 10, int killBonusEnergy = 0)
        {
            this.name = name;
            int numberOfAnimals = Simulation.numberOfAnimalsOnMap / totalNumberOfSpecies;
            animals = new Animal[numberOfAnimals];
            maxAnimals = numberOfAnimals;
            int mapLengthX = simulation.map.map.GetLength(0);
            int mapLengthY = simulation.map.map.GetLength(1);
            this.rnd = rnd;
            #region Settings
            this.baseMoveEnergy = baseMoveEnergy;
            this.waterMoveEnergy = waterMoveEnergy;
            this.mountainMoveEnergy = mountainMoveEnergy;
            this.eatEnergy = eatEnergy;
            this.searchFoodEnergy = searchFoodEnergy;
            this.searchEnemyEnergy = searchEnemyEnergy;
            this.fightEnergy = fightEnergy;
            this.fightSuccEnergy = fightSuccEnergy;
            this.killBonusEnergy = killBonusEnergy;
            this.attackStrength = attackStrength;
            this.maximumHealth = maximumHealth;
            #endregion
            for (int i = 0; i < numberOfAnimals; i++)
            {
                animals[i] = new Animal(name + animalNumber++, this, simulation, rnd.Next(mapLengthX), rnd.Next(mapLengthY), maximumHealth, attackStrength, mutationChance, rnd);
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
            if (maxAnimals < 2)
            {
                this.animals = new Animal[0];
                return;
            }

            var animals = this.animals.Reverse().ToList();
            int reqCount = animals.Count;

            // Remove all animals with not positive energy or with no health
            animals = animals.Where(x => x.energy > 0 && x.health > 0).ToList();
            int removedAnimalsBeforeBreeding = reqCount - animals.Count;

            // Remove all animals over limit
            int remAnim = animals.Count - maxAnimals;
            if (remAnim > 0)
                animals.RemoveRange(0, remAnim);


            int removedAnimals = reqCount / 2;
            if (removedAnimalsBeforeBreeding > removedAnimals)
                removedAnimals = removedAnimalsBeforeBreeding;

            if (animals.Count == 1)
            {
                animals.RemoveAt(0);
                return;
            }

            if (animals.Count == 0)
                return;

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
            animals.RemoveRange(0, removedAnimals - removedAnimalsBeforeBreeding);

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
                animals[i].health = animals[i].startHealth;
            }
        }

        public static void SetMaxNumberOfAnimalsForSpecies(Species[] species, int totalNumberOfAnimals)
        {
            double sum = species.Select(x => x.animals.Where(y => y.health > 0 && y.energy > 0).Select(y => y.energy).Sum()).Sum();
            // Assign number of allowed animals to each species
            for (int i = 0; i < species.Length; i++)
            {
                species[i].maxAnimals = (int)(totalNumberOfAnimals * (species[i].animals.Where(x => x.health > 0 && x.energy > 0).Select(x => x.energy).Sum() / sum));
            }
        }
    }
}
