using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary
{
    public class LenovoLaptop : Laptop
    {
        public LenovoLaptop()
        {
            Model = "ThinkPad X1 Carbon";
            Processor = "Intel Core i7";
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Lenovo Laptop - Model: {Model}, Processor: {Processor}");
        }
    }
}
