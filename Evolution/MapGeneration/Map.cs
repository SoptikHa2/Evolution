﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution.MapGeneration
{
    [Serializable]
    public class Map
    {
        public const int chanceToPosFood = 30;
        public const int minFood = 10;
        public const int maxFood = 15;

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
                    newMap[i, j] = new MapObject { x = i, y = j, level = map[i, j], food = rnd.Next(101) <= chanceToPosFood ? rnd.Next(minFood, maxFood + 1) : 0 };
                    newMap[i, j].objectsOnTile = new List<object>();
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

        public int GetNearestEnemyDirection(int x, int y, string mySpeciesName)
        {
            List<MapObject> possibleResults = new List<MapObject>();
            for(int i = 0; i < map.GetLength(0); i++)
            {
                for(int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j].objectsOnTile.Select(q => q is Evolution.Animal && (q as Evolution.Animal).speciesName != mySpeciesName).Count() > 0)
                        possibleResults.Add(map[i, j]);
                }
            }

            MapObject result = possibleResults.OrderBy(q => getDistance((q.objectsOnTile[0] as Evolution.Animal).x, (q.objectsOnTile[0] as Evolution.Animal).y, x, y)).FirstOrDefault();

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

        public Evolution.Animal GetNearEnemyAnimal(int x, int y, string mySpeciesName)
        {
            List<MapObject> possibleResults = new List<MapObject>();
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j].objectsOnTile.Select(q => q is Evolution.Animal && (q as Evolution.Animal).speciesName != mySpeciesName).Count() > 0)
                        possibleResults.Add(map[i, j]);
                }
            }

            return possibleResults.Where(q => getDistance((q.objectsOnTile[0] as Evolution.Animal).x, 0, x, 0) <= 1 && getDistance(0, (q.objectsOnTile[0] as Evolution.Animal).y, 0, y) <= 1).Select(q => q.objectsOnTile[0] as Evolution.Animal).FirstOrDefault();

        }

        private int getDistance(int fromX, int fromY, int toX, int toY)
        {
            return Math.Abs(fromX - toX) + Math.Abs(fromY - toY);
        }
    }
}
