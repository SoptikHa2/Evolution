﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution.Evolution
{
    public class Simulation
    {
        #region ColorSettings
        private static Brush sea = Brushes.Blue;
        private static Brush deepSea = Brushes.DarkBlue;
        private static Brush beach = Brushes.LightGoldenrodYellow;
        private static Brush land = Brushes.Green;
        private static Brush mountain = Brushes.SaddleBrown;
        #endregion
        #region TerrainHeightsSettings
        public const int minDeepSea = -2;
        public const int minSea = 0;
        public const int minBeach = 1;
        public const int minMountain = 5;
        #endregion

        private MapGeneration.Map map;
        private Species[] species;
        private int width, height;

        public Simulation(int width = 100, int height = 100)
        {
            this.width = width;
            this.height = height;
            map = new MapGeneration.Map(width, height);
            this.species = InitializeSpecies();
            Tick();
        }

        public Species[] InitializeSpecies()
        {
            // ...
            return new Species[] { new Species() };
        }

        public void Tick()
        {
            //while (true)
            {
                for (int i = 0; i < map.map.GetLength(0); i++)
                    for (int j = 0; j < map.map.GetLength(1); j++)
                        map.map[i, j].Tick();
                for (int i = 0; i < species.Length; i++)
                    species[i].Tick();
            }
        }

        public void DrawOnBitmap(Graphics graphics, int widthOfDrawArea, int heightOfDrawArea)
        {
            float lengthOfTile = Math.Min(widthOfDrawArea / (float)width, heightOfDrawArea / (float)height);

            // Draw terrain
            for (int i = 0; i < map.map.GetLength(0); i++)
            {
                for (int j = 0; j < map.map.GetLength(1); j++)
                {
                    MapGeneration.MapObject m = map.map[i, j];
                    Brush terrainBrush = getTerrainBrush(m.level);
                    graphics.FillRectangle(terrainBrush, i * lengthOfTile, j * lengthOfTile, lengthOfTile, lengthOfTile);
                }
            }
        }

        private Brush getTerrainBrush(int terrainLevel)
        {
            if (terrainLevel <= minDeepSea)
                return deepSea;
            else if (terrainLevel <= minSea)
                return sea;
            else if (terrainLevel <= minBeach)
                return beach;
            else if (terrainLevel < minMountain)
                return land;
            else
                return mountain;
        }
    }
}