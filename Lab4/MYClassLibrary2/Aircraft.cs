using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary2
{
    public class Aircraft
    {
        public string Name;
        private CommandCentre _commandCentre;

        public Aircraft(string name, CommandCentre commandCentre)
        {
            Name = name;
            _commandCentre = commandCentre;
        }

        public void Land()
        {
            Console.WriteLine($"Aircraft {Name} is landing.");
            Console.WriteLine($"Checking runway.");
            if (_commandCentre.IsRunwayFree())
            {
                var runway = _commandCentre.GetFreeRunway();
                Console.WriteLine($"Aircraft {Name} has landed on Runway {runway.Id}.");
                runway.HighLightRed();
                runway.SetActive(true);
            }
            else
            {
                Console.WriteLine($"Could not land, all runways are busy.");
            }
        }

        public void TakeOff()
        {
            Console.WriteLine($"Aircraft {Name} is taking off.");
            var runway = _commandCentre.GetFreeRunway();
            if (runway != null)
            {
                runway.SetActive(false);
                runway.HighLightGreen();
                Console.WriteLine($"Aircraft {Name} has taken off from Runway {runway.Id}.");
            }
            else
            {
                Console.WriteLine($"Could not take off, no available runways.");
            }
        }
    }
}
