using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Trains
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        public double GetBirdDistance(double totalDistance, double trainSpeed, double totalTime)
        {
            double birdTime = 1 / 8 * totalDistance / trainSpeed;
            double birdDistance = 1 / 4 * totalDistance * 2 * trainSpeed;
        }
    }
}
