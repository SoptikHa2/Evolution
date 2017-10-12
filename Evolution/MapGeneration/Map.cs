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
                    newMap[i, j] = new MapObject { x = i, y = j, level = map[i, j] };
                }
            }

            return newMap;
        }
    }
}
