using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRace
{
    public class Race
    {
        static readonly Random rnd = new Random();
        private List<Runner> _runners;


        public Race()
        {
            _runners = new List<Runner>();
        }

        public double CalculateMargin()
        {
            return _runners.Sum(x => x.DecimalPrice);
        }

        public List<Runner> Runners
        {
            get { return _runners; }
            set { _runners = value; }
        }

        public Runner CalculateWinner()
        {
            int index = rnd.Next(_runners.Count);

            return _runners[index];
        }

        void DisplayWinner(Runner runner) => Console.WriteLine($"The winner is: {runner.Name}, {runner.FractionalPrice}, Chance: {runner.Chance(CalculateMargin()):0.00}");

        public void RunRace()
        {
            var margin = CalculateMargin();
            if (margin > 140 || margin < 110)
                throw new ArgumentOutOfRangeException($"'{nameof(margin)}' must be between 110% and 140%");
            var winner = CalculateWinner();
            DisplayWinner(winner);
        }
    }
}
