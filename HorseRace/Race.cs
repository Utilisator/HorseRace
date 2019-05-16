using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRace
{
    public class Race
    {
        private List<Runner> _runners;

        public double CalculateMargin(List<Runner> runners)
        {
            return runners.Sum(x => x.DecimalPrice);
        }
    }
}
