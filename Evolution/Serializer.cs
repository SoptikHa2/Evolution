using System;
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
        public static void SaveSimulation(Evolution.Species[] species, MapGeneration.Map map, string[] dirPath, string fileName)
        {
            // Check for directories
            string path = "";
            for(int i = 0; i < dirPath.Length; i++)
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
