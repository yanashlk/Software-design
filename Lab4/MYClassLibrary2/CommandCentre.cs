using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary2
{
    public class CommandCentre
    {
        private List<Runway> _runways = new List<Runway>();

        public CommandCentre(Runway[] runways)
        {
            _runways.AddRange(runways);
        }

        public bool IsRunwayFree()
        {
            foreach (var runway in _runways)
            {
                if (!runway.IsActive)
                {
                    return true;
                }
            }
            return false;
        }

        public Runway? GetFreeRunway()
        {
            foreach (var runway in _runways)
            {
                if (!runway.IsActive)
                {
                    return runway;
                }
            }
            return null;
        }
    }
}
