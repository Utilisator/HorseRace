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

            for (int i = 0; i < 1000000; i++)
            {
                r.RunRace();
            }
            Console.ReadKey(true);
        }
    }
}
