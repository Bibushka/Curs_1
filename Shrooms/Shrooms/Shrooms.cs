using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Shrooms
{
    [TestClass]
    public class Shrooms
    {
        [TestMethod]
        public void FirstSpring()
        {
            int numberOfRedMushrooms = GetNumberOfMushrooms(3, 2);
            Assert.AreEqual(2, numberOfRedMushrooms);
        }

        public int GetNumberOfMushrooms(int total, int x)
        {
            int reds = x * total / (x + 1);
            return reds;
        }
    }
}
