﻿using System;
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
        private double margin;

        public Race()
        {
            _runners = new List<Runner>();
        }
        public List<Runner> Runners
        {
            get { return _runners; }
            set { _runners = value; }
        }

        public double Margin { get { return margin; } }

        private void CalculateMargin()
        {
            margin = _runners.Sum(x => x.DecimalPrice);
        }


        /// <summary>
        /// Calculating winner according this algorythm
        /// https://en.wikipedia.org/wiki/Alias_method and 
        /// http://code.activestate.com/recipes/576564-walkers-alias-method-for-random-objects-with-diffe/
        /// </summary>
        /// <returns></returns>
        public Runner CalculateWinner()
        {
            double sumOfAllChances = _runners.Sum(x => x.Chance(margin));
            double sumU = Math.Ceiling(sumOfAllChances);
            
            var pick = rnd.Next((int)sumU);

            double sum = 0;
            Runner res = new Runner();

            foreach (var item in _runners)
            {
                sum += item.Chance(margin);
                if (sum >= pick)
                {
                    res = item;
                    _runners[_runners.IndexOf(res)].winCount++;

                    break;
                }
            }

            return res;
        }

        void DisplayWinner(Runner runner) => Console.WriteLine($"The winner is: {runner.Name}, {runner.FractionalPrice}, Chance: {runner.Chance(margin):0.00}");

        public void RunRace(bool displayWinners = false)
        {
            CalculateMargin();

            if (margin > 140 || margin < 110)
                throw new ArgumentOutOfRangeException($"'{nameof(margin)}' must be between 110% and 140%");
            var winner = CalculateWinner();
            if (displayWinners) DisplayWinner(winner);

        }
    }
}
