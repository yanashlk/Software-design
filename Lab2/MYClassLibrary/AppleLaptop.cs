using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary
{
    public class AppleLaptop : Laptop
    {
        public override void DisplayInfo()
        {
            Console.WriteLine($"Apple Laptop - Model: {Model}, Processor: {Processor}");
        }
    }
}
