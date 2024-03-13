using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    public class Virus : ICloneableVirus
    {
        public double Weight { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public List<ICloneableVirus> Children { get; set; } = new List<ICloneableVirus>();

        public ICloneableVirus Clone()
        {
            return (ICloneableVirus)MemberwiseClone();
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Species: {Species}, Age: {Age}, Weight: {Weight}");
            Console.WriteLine($"Children: {Children.Count}");
            Console.WriteLine("----------------------------");
        }
    }
}
