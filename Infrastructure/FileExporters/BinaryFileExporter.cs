using Domain;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.FileExporters
{
    public class BinaryFileExporter : IFileExporter
    {
        public void Save(Shape shape)
        {
            IFormatter formatter = new BinaryFormatter();

            var directory = $"c:/temp/binFiles";
            Directory.CreateDirectory(directory);

            Stream stream = new FileStream(directory + $"/{shape.Name}_{DateTime.Now.ToString("yyyyMMddTHHmmss")}.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, shape);
            stream.Close();
        }
    }
}
