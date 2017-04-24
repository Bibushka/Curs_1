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
            int whites = total / (x + 1);
            int reds = x * whites;
            return reds;
        }
    }
}
