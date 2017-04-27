using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Trains
{
    [TestClass]
    public class Trains
    {
        [TestMethod]
        public void TestMethod1()
        {
            double birdDistance = GetBirdDistance(4, 1);
            Assert.AreEqual(2, birdDistance);
        }

        public double GetBirdDistance(double totalDistance, double trainSpeed)
        {
            double totalTime = totalDistance / trainSpeed;
            double birdTime = 1 / 4 * totalTime;
            double birdDistance = birdTime * 2 * trainSpeed;
            return birdDistance;
        }
    }
}
