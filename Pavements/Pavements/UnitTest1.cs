﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pavements
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double numberOfSlabs = GetNumberOfSlabs(6, 6, 4, 4);
            Assert.AreEqual(4, numberOfSlabs);
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
