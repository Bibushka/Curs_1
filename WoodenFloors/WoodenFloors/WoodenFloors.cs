using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WoodenFloors
{
    [TestClass]
    public class WoodenFloors
    {
        [TestMethod]
        public void TestMethod1()
        {
            double numberOfWoodPieces = CalculateWoodPieces(5, 2, 1, 1);
            Assert.AreEqual(12, numberOfWoodPieces);
        }

        public double CalculateWoodPieces(double roomLength, double roomWidth, double woodPieceLength, double woodPieceWidth)
        {
            double roomSurface = roomLength * roomWidth;
            double woodPieceSurface = woodPieceLength * woodPieceWidth;
            double numberOfWoodPieces = Math.Ceiling(roomSurface * 1.15 / woodPieceSurface);
            return numberOfWoodPieces;
        }
    }
}
