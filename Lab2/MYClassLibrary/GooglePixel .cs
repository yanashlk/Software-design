using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary
{
    public class GooglePixel : Smartphone
    {
        public GooglePixel()
        {
            Brand = "Google";
            OS = "Android";
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Google Pixel Smartphone - Brand: {Brand}, OS: {OS}");
        }
    }
}
