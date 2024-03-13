using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    public class VirusFamily
    {
        public readonly List<Virus> viruses = new List<Virus>();

        public void AddVirus(Virus virus)
        {
            viruses.Add(virus);
        }

        public void DisplayFamilyInfo()
        {
            foreach (var virus in viruses)
            {
                virus.DisplayInfo();
            }
        }
    }
}
