using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary4
{
    public class SmartTextChecker : SmartTextReader
    {
        public new char[,] ReadTextFile(string filePath)
        {
            Console.WriteLine($"Opening file: {filePath}");
            char[,] textArray = base.ReadTextFile(filePath);
            Console.WriteLine($"Successfully read file: {filePath}");
            Console.WriteLine($"Total lines: {textArray.GetLength(0)}, Total characters: {textArray.Length}");
            Console.WriteLine($"Closing file: {filePath}");
            return textArray;
        }
    }
}
