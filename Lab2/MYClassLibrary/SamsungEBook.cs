using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary
{
    public class SamsungEBook : EBook
    {
        public override void DisplayInfo()
        {
            Console.WriteLine($"Samsung EBook - Title: {Title}, Author: {Author}");
        }
    }
}
