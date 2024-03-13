using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary
{
    public class XiaomiNetbook : Netbook
    {
        public override void DisplayInfo()
        {
            Console.WriteLine($"Xiaomi Netbook - Model: {Model}, Battery Life: {BatteryLife} hours");
        }
    }
}
