using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pavements
{
    [TestClass]
    public class Pavements
    {
        [TestMethod]
        public void MyResult()
        {
            double numberOfSlabs = GetNumberOfSlabs(6, 6, 4, 4);
            Assert.AreEqual(3, numberOfSlabs);
        }

        public double GetNumberOfSlabs(double marketLenght, double marketWidth, double slabLenght, double slabWidth)
        {
            double marketArea = marketLenght * marketWidth;
            double slabArea = slabLenght * slabWidth;
            double numberOfSlabs = Math.Ceiling(marketArea / slabArea);
            return numberOfSlabs;
        }
    }
}
