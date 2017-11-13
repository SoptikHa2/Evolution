using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evolution.Evolution;

namespace Evolution.MapGeneration
{
    [Serializable]
    public class Map
    {
        public int chanceToPosFood = 30;
        public int minFood = 10;
        public int maxFood = 15;

        public MapObject[,] map { get; private set; }
        private Random rnd;

        public Map(Random random, int width = 100, int height = 100, int chanceToPosFood = 30, int minFood = 10, int maxFood = 15)
        {
            this.chanceToPosFood = chanceToPosFood;
            this.minFood = minFood;
            this.maxFood = maxFood;
            rnd = random;
            int[,] map = new Generator(width, height, random).Generate();
            this.map = ConvertMap(map);
        }

        private MapObject[,] ConvertMap(int[,] map)
        {
            int width = map.GetLength(0);
            int height = map.GetLength(1);
            MapObject[,] newMap = new MapObject[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    newMap[i, j] = new MapObject { x = i, y = j, level = map[i, j], food = rnd.Next(101) <= chanceToPosFood ? rnd.Next(minFood, maxFood + 1) : 0 };
                }
            }

            return newMap;
        }

        public int GetNearestFoodDirection(int x, int y)
        {
            if (map[x, y].food > 0)
                return -1;

            List<MapObject> possibleResults = new List<MapObject>();
            for(int i = 0; i < map.GetLength(0); i++)
            {
                for(int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j].food > 0)
                        possibleResults.Add(map[i, j]);
                }
            }

            if (possibleResults.Count < 1)
                return -1;

            MapObject result = possibleResults.OrderBy(a => getDistance(a.x, a.y, x, y)).ThenBy(a => a.food).FirstOrDefault();

            if (result.x > x)
                return 0;
            else if (result.y > y)
                return 1;
            else if (result.x < x)
                return 2;
            else if (result.y < y)
                return 3;
            else
                return -1;
        }

        public int GetNearestEnemyDirection(int x, int y, Species mySpecies, Simulation simulation)
        {
            List<Animal> possibleResults = new List<Animal>();

            // Go thru all species (except the one that is species of animal that called this method)
            for(int i = 0; i < simulation.species.Length; i++)
            {
                if (simulation.species[i] == mySpecies)
                    continue;

                // Add all animals from the species to possibleResults list, if it has at least 1 HP
                for(int j = 0; j < simulation.species[i].animals.Length; j++)
                {
                    if (simulation.species[i].animals[j].health > 0)
                        possibleResults.Add(simulation.species[i].animals[j]);
                }
            }

            // Order results and pick the nearest one
            Animal result = possibleResults.OrderBy(q => getDistance(q.x, q.y, x, y)).FirstOrDefault();

            if (result.x > x)
                return 0;
            else if (result.y > y)
                return 1;
            else if (result.x < x)
                return 2;
            else if (result.y < y)
                return 3;
            else
                return -1;
        }

        public Animal GetNearEnemyAnimal(int x, int y, Species mySpecies, Simulation simulation)
        {
            List<Animal> possibleResults = new List<Animal>();

            // Go thru all species (except the one that is species of animal that called this method)
            for (int i = 0; i < simulation.species.Length; i++)
            {
                if (simulation.species[i] == mySpecies)
                    continue;

                // Add all animals from the species to possibleResults list, if it has at least 1 HP
                for (int j = 0; j < simulation.species[i].animals.Length; j++)
                {
                    if (simulation.species[i].animals[j].health > 0)
                        possibleResults.Add(simulation.species[i].animals[j]);
                }
            }

            // Return animal that is at most 1 tile away from animal
            return possibleResults.Where(q => getDistance(q.x, 0, x, 0) <= 1 && getDistance(0, q.y, 0, y) <= 1).FirstOrDefault();
        }

        private int getDistance(int fromX, int fromY, int toX, int toY)
        {
            return Math.Abs(fromX - toX) + Math.Abs(fromY - toY);
        }
    }
}
