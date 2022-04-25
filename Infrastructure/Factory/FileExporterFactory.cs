using Infrastructure.FileExporters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Factory
{
    public class FileExporterFactory
    {
        public static IFileExporter GetFileExporter(string fileFormat)
        {
            switch (fileFormat)
            {
                case "xml":
                    return new XMLFileExporter();

                case "json":
                    return new JSONFileExporter();

                case "binary":
                    return new BinaryFileExporter();

                default:
                    throw new ArgumentException();
            }
        }
    }
}
