using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution.MapGeneration
{
    public class Generator
    {
        private Random rnd;
        private int[,] map;

        #region Settings
        private int width = 100;
        private int height = 100;
        private int enableNeighbour = 4;
        private int disableNeighbour = 4;
        private int smoothLevel = 7;
        #endregion

        public Generator(int width = 100, int height = 100, string seed = null, int smoothLevel = 7, int enableNeighbour = 4, int disableNeighbour = 4)
        {
            this.width = width;
            this.height = height;
            this.map = new int[width, height];
            rnd = String.IsNullOrEmpty(seed) ? new Random() : new Random(seed.GetHashCode());
            this.smoothLevel = smoothLevel;
            this.enableNeighbour = enableNeighbour;
            this.disableNeighbour = disableNeighbour;
        }

        #region Generating
        public int[,] Generate()
        {
            RandomNoise();
            Smooth(10);
            GenerateHeightmap();
            //GenerateDepths();
            return map;
        }

        /// <summary>
        /// Generate random noise into heightmap
        /// </summary>
        private void RandomNoise()
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    map[i, j] = rnd.Next(2);
                }
            }
        }

        /// <summary>
        /// Smooth map in [n] cycles
        /// </summary>
        /// <param name="n">Number of cycles. One is enough, but it usually leavs some lone cells there</param>
        private void Smooth(int n)
        {
            for (int a = 0; a < n; a++)
            {
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        if (map[i, j] == 0)
                        {
                            if (GetNeighbours(i, j) > enableNeighbour)
                                map[i, j] = 1;
                        }
                        else
                        {
                            if (GetNeighbours(i, j) < disableNeighbour)
                                map[i, j] = 0;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Get number of neighbours with value [target] next to cell [x][y]
        /// </summary>
        /// <param name="x">Width of cell</param>
        /// <param name="y">Height of cell</param>
        /// <param name="target">Target value of neighbours</param>
        /// <returns></returns>
        private int GetNeighbours(int x, int y, int target = 1)
        {
            int c = 0;

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (i == 0 && j == 0)
                        continue;

                    if (x + i < 0 || y + j < 0 || x + i >= width || y + j >= height)
                        continue;

                    if (map[x + i, y + j] == target)
                        c++;
                }
            }

            return c;
        }

        /// <summary>
        /// Generate another number than 0 or 1, when the cell's length from any other 0 cell is bigger, the number is bigger
        /// </summary>
        private void GenerateHeightmap()
        {
            // Make two copies of default map
            int[,] newMap = new int[width, height];
            int[,] puvodniMapa = new int[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    newMap[i, j] = map[i, j];
                    puvodniMapa[i, j] = map[i, j];
                }
            }

            // Count length from another 0 cell
            int iter = 1;

            // When there is any cell, that hasn't been counted yet
            while (map.OfType<int>().Where(x => x != 0).Count() > 0)
            {
                // Go thru all cells
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        // Skip all 0 cells and cells with no 0 neighbours
                        if (map[i, j] != 0 && GetNeighbours(i, j, 0) > 0)
                        {
                            // Change number to 1st copy
                            newMap[i, j] = iter;
                            // Set affected cells to 0 in 2nd copy
                            puvodniMapa[i, j] = 0;
                        }
                    }
                }

                iter++;

                // Copy 2nd copy into regular map
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        map[i, j] = puvodniMapa[i, j];
                    }
                }
            }

            // Save changes
            map = newMap;
        }

        /// <summary>
        /// Generate deeps in there. The bigger is the length from nearest '1+' cell, the bigger deep will be there. Simmilar like [GenerateHeightmap()].
        /// </summary>
        private void GenerateDepths()
        {
            // Make two copies of default map
            int[,] newMap = new int[width, height];
            int[,] puvodniMapa = new int[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    newMap[i, j] = map[i, j];
                    puvodniMapa[i, j] = map[i, j];
                }
            }

            // Count length from another 1+ cell
            int iter = 0;

            // When there is any cell, that hasn't been counted yet
            while (map.OfType<int>().Where(x => x <= 0).Count() > 0)
            {
                // Go thru all cells
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        // Skip all 1+ cells and cells with no '1' neighbours
                        if (map[i, j] < 1 && GetNeighbours(i, j, 1) > 0)
                        {
                            // Change number to 1st copy
                            newMap[i, j] = iter;
                            // Set affected cells to 1 in 2nd copy
                            puvodniMapa[i, j] = 1;
                        }
                    }
                }

                iter--;

                // Copy 2nd copy into regular map
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        map[i, j] = puvodniMapa[i, j];
                    }
                }
            }

            // Save changes
            map = newMap;
        }
        #endregion
    }
}
