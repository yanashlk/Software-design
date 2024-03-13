using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary
{
    public abstract class Smartphone
    {
        public string Brand { get; set; }
        public string OS { get; set; }
        public abstract void DisplayInfo();
    }
}
