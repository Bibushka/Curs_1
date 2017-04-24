using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Curs_1___goats_1
{
    [TestClass]
    public class Goats
    {
        [TestMethod]
        public void TestMethod1()
        {
            int kilos = GetKilograms(1, 1, 1, 1, 2);
            Assert.AreEqual(2, kilos);
        }

        public int GetKilograms(int initialNumberOfDays, int initialNumberOfGoats,  int initialKilogramsOfHay, int numberOfDays, int numberOfGoats)
        {
            return numberOfDays * numberOfGoats * initialKilogramsOfHay / initialNumberOfDays / initialNumberOfGoats;
        }
    }
}
