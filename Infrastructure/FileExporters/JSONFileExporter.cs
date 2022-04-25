using Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.FileExporters
{
    public class JSONFileExporter : IFileExporter
    {
        public void Save(Shape shape)
        {
            var directory = $"c:/temp/jsonFiles";
            Directory.CreateDirectory(directory);

            string jsonFormat = JsonConvert.SerializeObject(shape, Formatting.Indented);
            File.WriteAllText(directory + $"/{shape.Name}_{DateTime.Now.ToString("yyyyMMddTHHmmss")}.json", jsonFormat);
        }
    }
}

