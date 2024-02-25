using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryATM
{
    //Composition Over Inheritance та DRY
    public class Bank
    {
        public string Name { get; set; }
        public List<AutomatedTellerMachine> ATMs { get; set; } = new List<AutomatedTellerMachine>();

    }
}
