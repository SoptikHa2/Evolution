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
        private const int generationTicks = 50;
        #endregion
        #region DrawSettings
        private const int savedImageWidth = 720;
        private const int savedImageHeight = 720;
        #endregion
        #region Settings
        public const int baseMoveEnergy = 0;
        public const int waterMoveEnergy = 0;
        public const int mountainMoveEnergy = 0;

        public const int eatEnergy = 1;
        public const int searchFoodEnergy = 0;

        public const int numberOfAnimalsOnMap = 100;
        #endregion

        private MapGeneration.Map map;
        public Species[] species;
        private int width, height;
        private DateTime dateTimeStarted;

        private static Random rnd = new Random();

        [NonSerialized]
        private Thread tickThread;

        public event EventHandler NextTick;
        public event EventHandler NextGeneration;

        public Simulation(int width = 100, int height = 100)
        {
            this.width = width;
            this.height = height;
            dateTimeStarted = DateTime.Now;
            map = new MapGeneration.Map(width, height);
            this.species = InitializeSpecies();
            tickThread = new Thread(Tick);
            tickThread.Name = "Simulation Tick Thread";
        }

        public Simulation() { }

        public Species[] InitializeSpecies()
        {
            return new Species[] { new Species("Fox", map, "red", 3), new Species("Sheep", map, "silver", 3), new Species("Goat", map, "orange", 3) };
        }

        public void SetOnLoad(MapGeneration.Map map, Species[] species, int generation)
        {
            this.map = map;
            this.species = species;
            this.generation = generation;
        }

        public void StartTicks()
        {
            tickThread.Start();
        }

        private int tick = 0;
        public int generation { get; private set; }
        public int playTicks = -1;
        public void Tick()
        {
            while (true)
            {
                // If ticks arent turned on, wait
                if (playTicks != 0)
                    playTicks--;
                else
                {
                    while (playTicks == 0)
                        Thread.Sleep(10);
                    if (playTicks > 0)
                        playTicks--;
                }

                // Save some data at beginning of generation
                if (tick == 0)
                {
                    Serializer.BeforeGenerationSave(species, map, generation++, dateTimeStarted);
                }

                // Tick all objects
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

                    // Add new food to tiles
                    for (int i = 0; i < map.map.GetLength(0); i++)
                        for (int j = 0; j < map.map.GetLength(1); j++)
                            map.map[i, j].food = rnd.Next(101) <= MapGeneration.Map.chanceToPosFood ? rnd.Next(MapGeneration.Map.minFood, MapGeneration.Map.maxFood) : 0;

                    // Save image of end of previous generation
                    Bitmap b = new Bitmap(savedImageWidth, savedImageHeight);
                    Graphics g = Graphics.FromImage(b);
                    DrawOnBitmap(g, savedImageWidth, savedImageHeight, false);

                    // Order animals
                    for (int i = 0; i < species.Length; i++)
                        species[i].animals = species[i].animals.OrderByDescending(x => x.energy).ToArray();


                    // Save some additional files to log
                    Serializer.AfterGenerationSave(b, species, generation, dateTimeStarted);

                    // Calculate number of allowed animals for each species
                    Species.SetMaxNumberOfAnimalsForSpecies(species, numberOfAnimalsOnMap);
                    // Breed new animals
                    foreach (Species s in species)
                        s.NewGeneration(map);

                    // Reset animals energy & position
                    foreach (Species s in species)
                        s.ResetAnimals(width, height);

                    NextGeneration(this, EventArgs.Empty);
                }
            }
        }

        private readonly object _lock = new object();
        public bool drawFoodOverlay = false;
        public void DrawOnBitmap(Graphics graphics, int widthOfDrawArea, int heightOfDrawArea, bool respectDrawFoodOverlay = true)
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
                // Draw food overlay
                if (respectDrawFoodOverlay && drawFoodOverlay)
                {
                    for (int i = 0; i < map.map.GetLength(0); i++)
                    {
                        for (int j = 0; j < map.map.GetLength(1); j++)
                        {
                            MapGeneration.MapObject m = map.map[i, j];
                            Brush brush = getFoodBrush(m.food);
                            graphics.FillRectangle(brush, i * lengthOfTile, j * lengthOfTile, lengthOfTile, lengthOfTile);
                        }
                    }
                }
                // Draw animals
                for (int spN = 0; spN < species.Length; spN++)
                {
                    Species sp = species[spN];
                    for (int aN = 0; aN < sp.animals.Length; aN++)
                    {
                        Animal a = sp.animals[aN];
                        if (a.health < 1)
                            continue;
                        SolidBrush sb = new SolidBrush(Color.FromName(sp.speciesColor));
                        graphics.FillRectangle(sb, a.x * lengthOfTile, a.y * lengthOfTile, lengthOfTile, lengthOfTile);
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

        private Brush getFoodBrush(int food)
        {
            byte rMin = 255;
            byte gMin = 0;
            byte bMin = 0;

            byte rMax = 0;
            byte gMax = 255;
            byte bMax = 0;

            int max = MapGeneration.Map.maxFood;

            int r = (int)(rMin + (food / (double)max) * ((rMax - rMin)));
            int g = (int)(gMin + (food / (double)max) * ((gMax - gMin)));
            int b = (int)(bMin + (food / (double)max) * ((bMax - bMin)));

            return new SolidBrush(Color.FromArgb(128, r, g, b));
        }
    }
}
