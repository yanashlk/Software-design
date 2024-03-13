using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary
{
    public abstract class Netbook
    {
        public string Model { get; set; }
        public int BatteryLife { get; set; }
        public abstract void DisplayInfo();
    }
}
