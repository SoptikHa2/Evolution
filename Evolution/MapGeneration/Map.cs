using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution.MapGeneration
{
    public class Map
    {
        public MapObject[,] map { get; private set; }
        private static Random rnd = new Random();

        public Map(int width = 100, int height = 100, string seed = null)
        {
            int[,] map = new Generator(width, height, seed).Generate();
            this.map = ConvertMap(map);
        }

        private static MapObject[,] ConvertMap(int[,] map)
        {
            int width = map.GetLength(0);
            int height = map.GetLength(1);
            MapObject[,] newMap = new MapObject[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    newMap[i, j] = new MapObject { x = i, y = j, level = map[i, j], food = rnd.Next(0, 11) };
                }
            }

            return newMap;
        }

        public int getNearestFoodDirection(int x, int y)
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

        private int getDistance(int fromX, int fromY, int toX, int toY)
        {
            return Math.Abs(fromX - toX) + Math.Abs(fromY - toY);
        }
    }
}
