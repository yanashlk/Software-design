using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary
{
    public class FileLoggerAdapter : Logger
    {
        private FileWriter fileWriter;

        public FileLoggerAdapter(string filePath)
        {
            fileWriter = new FileWriter(filePath);
        }

        public new void Log(string message)
        {
            fileWriter.WriteLine($"Log: {message}");
            base.Log(message);
        }

        public new void Error(string message)
        {
            fileWriter.WriteLine($"Error: {message}");
            base.Error(message);
        }

        public new void Warn(string message)
        {
            fileWriter.WriteLine($"Warn: {message}");
            base.Warn(message);
        }
    }
}
