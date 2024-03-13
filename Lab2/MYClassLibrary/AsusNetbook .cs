using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary
{
    public class AsusNetbook : Netbook
    {
        public AsusNetbook()
        {
            Model = "EeeBook";
            BatteryLife = 8;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Asus Netbook - Model: {Model}, Battery Life: {BatteryLife} hours");
        }
    }
}
