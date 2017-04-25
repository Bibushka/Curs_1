using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Athlete
{
    [TestClass]
    public class Athlete
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result = BurningCarbs(5);
            Assert.AreEqual(30, result);
        }

        public int BurningCarbs(int numberOfExercizes)
        {
            int numberOfRepetitions = 2 * (numberOfExercizes + 1) * numberOfExercizes / 2;
            return numberOfRepetitions;
        }
    }
}
