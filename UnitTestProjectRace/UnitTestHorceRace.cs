using System;
using System.Collections.Generic;
using HorseRace;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectRace
{
    [TestClass]
    public class UnitTestHorceRace
    {
        [TestMethod]
        public void TestMethodRunRace()
        {
            Race r = new Race()
            {
                Runners = new List<Runner>() {
                    { new Runner("Test1", 1, 2) },
                    {new Runner("Test1", 2, 1)},
                    {new Runner("Test1", 3, 1)},
                    {new Runner("Test1", 8, 1)},
                }
            };

            for (int i = 0; i < 10; i++)
            {
                r.CalculateWinner();
            }
            
        }
    }
}
