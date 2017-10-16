﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Evolution
{
    public class Serializer
    {
        public static void BeforeGenerationSave(Evolution.Species[] species, MapGeneration.Map map, int generation, DateTime dateTimeStarted)
        {
            try
            {
                SaveSimulation(species, map, new string[] { "log", dateTimeStarted.ToString("dd-MM-yyy--HH-mm-ss"), "Generation " + generation }, DateTime.Now.ToString("HH-mm-ss"));
                File.WriteAllText($"log\\{ dateTimeStarted.ToString("dd-MM-yyy--HH-mm-ss")}\\Generation {generation}\\sim.dat", $"{generation};{dateTimeStarted.ToBinary()}");
            }
            catch (Exception ex)
            {
                if (!Directory.Exists("error"))
                    Directory.CreateDirectory("error");
                File.AppendAllText($"error\\Error_{dateTimeStarted.ToString("dd-MM-yyy--HH-mm-ss")}_{generation}.txt", ex.ToString() + Environment.NewLine + Environment.NewLine);
            }
        }

        public static void AfterGenerationSave(System.Drawing.Bitmap b, Evolution.Species[] species, int generation, DateTime dateTimeStarted)
        {
            try
            {
                b.Save($"log\\{dateTimeStarted.ToString("dd-MM-yyy--HH-mm-ss")}\\Generation {generation - 1}\\end of generation.png", System.Drawing.Imaging.ImageFormat.Png);
            }
            catch (Exception ex)
            {
                if (!Directory.Exists("error"))
                    Directory.CreateDirectory("error");
                File.AppendAllText($"error\\Error_{dateTimeStarted.ToString("dd-MM-yyy--HH-mm-ss")}_{generation}.txt", ex.ToString() + Environment.NewLine + Environment.NewLine);
            }

            try
            {
                // Save all animals log
                string animalSaveData = "";
                foreach (Evolution.Species s in species)
                    foreach (Evolution.Animal a in s.animals)
                        animalSaveData += a.ToString() + Environment.NewLine;
                File.WriteAllText($"log\\{dateTimeStarted.ToString("dd-MM-yyy--HH-mm-ss")}\\Generation {generation - 1}\\animals.dat", animalSaveData);
            }
            catch (Exception ex)
            {
                if (!Directory.Exists("error"))
                    Directory.CreateDirectory("error");
                File.AppendAllText($"error\\Error_{dateTimeStarted.ToString("dd-MM-yyy--HH-mm-ss")}_{generation}.txt", ex.ToString() + Environment.NewLine + Environment.NewLine);

            }

            try
            {
                // Generate statistics for each species
                for (int i = 0; i < species.Length; i++)
                {
                    File.WriteAllText($"log\\{dateTimeStarted.ToString("dd-MM-yyy--HH-mm-ss")}\\Generation {generation - 1}\\species_{species[i].name}.dat",
                        $"Species best energy: {species[i].animals[0].energy}, sum energy: {species[i].animals.Select(x => x.energy).Sum()}{Environment.NewLine}{Environment.NewLine}" +
                        $"Best animal:{Environment.NewLine}{species[i].animals[0].ToString()}{Environment.NewLine}{Environment.NewLine}" +
                        $"Middle animal:{Environment.NewLine}{species[i].animals[species[i].animals.Length / 2].ToString()}{Environment.NewLine}{Environment.NewLine}" +
                        $"Worst animal:{Environment.NewLine}{species[i].animals.Last().ToString()}");
                }
            }
            catch (Exception ex)
            {
                if (!Directory.Exists("error"))
                    Directory.CreateDirectory("error");
                File.AppendAllText($"error\\Error_{dateTimeStarted.ToString("dd-MM-yyy--HH-mm-ss")}_{generation}.txt", ex.ToString() + Environment.NewLine + Environment.NewLine);

            }
        }

        private static void SaveSimulation(Evolution.Species[] species, MapGeneration.Map map, string[] dirPath, string fileName)
        {
            // Check for directories
            string path = "";
            for (int i = 0; i < dirPath.Length; i++)
            {
                path += dirPath[i];
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                path += "\\";
            }

            // Generate string
            string save = SerializeObject(species);
            // Save string
            File.WriteAllText(path + fileName + ".species", save);

            save = SerializeObject(map);
            File.WriteAllText(path + fileName + ".map", save);
        }

        private static string SerializeObject(object o)
        {
            if (!o.GetType().IsSerializable)
            {
                return null;
            }

            using (MemoryStream stream = new MemoryStream())
            {
                new BinaryFormatter().Serialize(stream, o);
                return Convert.ToBase64String(stream.ToArray());
            }
        }

        private static object DeserializeObject(string str)
        {
            byte[] bytes = Convert.FromBase64String(str);

            using (MemoryStream stream = new MemoryStream(bytes))
            {
                return new BinaryFormatter().Deserialize(stream);
            }
        }

        public static T DeepClone<T>(T obj)
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Position = 0;

                return (T)formatter.Deserialize(ms);
            }
        }
    }
}
