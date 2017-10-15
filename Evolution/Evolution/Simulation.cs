using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Evolution.Evolution
{
    [Serializable]
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
        #region GenerationSettings
        private const int generationTicks = 100;
        #endregion
        #region DrawSettings
        private const int savedImageWidth = 720;
        private const int savedImageHeight = 720;
        #endregion

        private MapGeneration.Map map;
        public Species[] species;
        private int width, height;
        private DateTime dateTimeStarted;

        [NonSerialized]
        private Thread tickThread;

        public event EventHandler NextTick;
        public event EventHandler NextGeneration;

        public Simulation(int width = 100, int height = 100)
        {
            this.width = width;
            this.height = height;
            map = new MapGeneration.Map(width, height);
            this.species = InitializeSpecies();
            tickThread = new Thread(Tick);
            tickThread.Name = "Evolution: Simulation Tick Thread";
            tickThread.Start();
            dateTimeStarted = DateTime.Now;
        }

        public Simulation() { }

        public Species[] InitializeSpecies()
        {
            return new Species[] { new Species("fox", map, "orange") };
        }

        private int tick = 0;
        private int generation = 0;
        public void Tick()
        {
            DateTime lastThreadCall = DateTime.Now;
            while (true)
            {
                // If at beginning of generation, save some data
                if (tick == 0)
                {
                    Serializer.SaveSimulation(species, map, new string[] { "log", dateTimeStarted.ToString("dd-MM-yyy--hh-mm-ss"), "Generation " + generation++ }, DateTime.Now.ToString("hh-mm-ss"));
                    System.IO.File.WriteAllText($"log\\{ dateTimeStarted.ToString("dd-MM-yyy--hh-mm-ss")}\\Generation {generation}\\sim.dat", $"{generation - 1};{dateTimeStarted.ToBinary()}");
                    string animalSaveData = "";
                    foreach (Species s in species)
                        foreach (Animal a in s.animals)
                            animalSaveData += a.ToString() + Environment.NewLine;
                    System.IO.File.WriteAllText($"log\\{dateTimeStarted.ToString("dd-MM-yyy--hh-mm-ss")}\\Generation {generation - 1}\\animals.dat", animalSaveData);
                }

                // Tick all objects
                lastThreadCall = DateTime.Now;
                for (int i = 0; i < map.map.GetLength(0); i++)
                    for (int j = 0; j < map.map.GetLength(1); j++)
                        map.map[i, j].Tick();
                for (int i = 0; i < species.Length; i++)
                    species[i].Tick();
                NextTick(this, EventArgs.Empty);

                // If there is new generation
                if (tick++ >= generationTicks)
                {
                    tick = 0;
                    foreach (Species s in species)
                        s.NewGeneration();
                    NextGeneration(this, EventArgs.Empty);


                    // Save image of end of previous generation
                    Bitmap b = new Bitmap(savedImageWidth, savedImageHeight);
                    Graphics g = Graphics.FromImage(b);
                    DrawOnBitmap(g, savedImageWidth, savedImageHeight);
                    b.Save($"log\\{dateTimeStarted.ToString("dd-MM-yyy--hh-mm-ss")}\\Generation {generation - 1}\\end of generation.png", System.Drawing.Imaging.ImageFormat.Png);
                }
            }
        }

        private readonly object _lock = new object();
        public void DrawOnBitmap(Graphics graphics, int widthOfDrawArea, int heightOfDrawArea)
        {
            lock (_lock)
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
                // Draw animals
                for (int spN = 0; spN < species.Length; spN++)
                {
                    Species sp = species[spN];
                    for (int aN = 0; aN < sp.animals.Length; aN++)
                    {
                        Animal a = sp.animals[aN];
                        graphics.FillRectangle(new SolidBrush(Color.FromName(sp.speciesColor)), a.x * lengthOfTile, a.y * lengthOfTile, lengthOfTile, lengthOfTile);
                    }
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
