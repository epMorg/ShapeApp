using Domain;
using System.Xml.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.FileExporters
{
    public class XMLFileExporter : IFileExporter
    {
        public void Save(Shape shape)
        {
            XmlSerializer writer =
            new System.Xml.Serialization.XmlSerializer(typeof(Shape));

            var directory = $"c:/temp/xmlFiles";
            Directory.CreateDirectory(directory);

            var path = directory + $"/{shape.Name}_{DateTime.Now.ToString("yyyyMMddTHHmmss")}.xml";
            FileStream file = File.Create(path);

            writer.Serialize(file, shape);
            file.Close();
        }
    }
}

