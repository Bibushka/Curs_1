using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archeology
{
    [TestClass]
    public class Archeology
    {
        [TestMethod]
        public void TestMethod1()
        {
            double buildingSurface = CalculateBuildingSurface(0, 0, 1, 0, 0, 1);
            Assert.AreEqual(0.5, buildingSurface);
        }

        public double CalculateBuildingSurface(double xA, double yA, double xB, double yB, double xC, double yC)
        {
            double sideOne = Math.Sqrt(Math.Pow((xA - xB), 2) + Math.Pow((yA - yB), 2));
            double sideTwo = Math.Sqrt(Math.Pow((xB - xC), 2) + Math.Pow((yB - yC), 2));
            double sideThree = Math.Sqrt(Math.Pow((xC - xA), 2) + Math.Pow((yC - yA), 2));
            double semiPerimetre = (sideOne + sideTwo + sideThree) / 2;
            double buildingSurface = Math.Sqrt(semiPerimetre * (semiPerimetre - sideOne) * (semiPerimetre - sideTwo) * (semiPerimetre - sideThree));
            return buildingSurface;
        }
    }
}
