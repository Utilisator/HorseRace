using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRace
{
    class Program
    {
        static void Main(string[] args)
        {
            Race r = new Race()
            {
                Runners = new List<Runner>() {
                    { new Runner("Test1", 1, 2) },
                    {new Runner("Test2", 2, 1)},
                    {new Runner("Test3", 3, 1)},
                    {new Runner("Test4", 8, 1)},
                }
            };
            //r.CalculateMargin();
            //Console.WriteLine(r.Margin);

            for (int i = 0; i < 1000000; i++)
            {
                var winner = r.RunRace();
                //r.Runners[r.Runners.IndexOf(winner)].winCount++;
            }
            foreach (var item in r.Runners)
            {
                Console.WriteLine($"{item.Name}\t{item.Chance(r.Margin):0.00}\t{item.winCount}");
                //Console.WriteLine($"{item.Name}\t{item.Chance(r.Margin):0.00}");
            }
            Console.ReadKey(true);
        }
    }
}
