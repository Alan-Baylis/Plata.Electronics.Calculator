using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Plata.Electronics.Calculator.Components.Resistors;

namespace Plata.Electronics.Calculator.Test.Components.Resistors
{
    [TestClass]
    public class BandTest
    {
        [TestMethod]
        public void TestNormalBand()
        {
            Band band = new Band();
            band.Color = ResistorColor.Blue;

            Assert.AreEqual(6, band.Value);
        }

        [TestMethod]
        public void TestMultiplierBand()
        {
            MultiplierBand band = new MultiplierBand();
            band.Color = ResistorMultiplier.Red;

            Assert.AreEqual(100, band.Value);
        }

        [TestMethod]
        public void TestToleranceBand()
        {
            ToleranceBand band = new ToleranceBand();
            band.Color = ResistorTolerance.Gold;

            Assert.AreEqual(5, band.Value);
        }

        [TestMethod]
        public void TestFourBands()
        {
            Band firstBand = new Band();
            Band secondBand = new Band();
            MultiplierBand thirdBand = new MultiplierBand();
            ToleranceBand fourthBand = new ToleranceBand();

            //25000 +-25%
            firstBand.Color = ResistorColor.Red;
            secondBand.Color = ResistorColor.Green;
            thirdBand.Color = ResistorMultiplier.Orange;
            fourthBand.Color = ResistorTolerance.Silver;

            float value = ((10 * firstBand.Value) + secondBand.Value) * thirdBand.Value;

            Assert.AreEqual(25000, value);
        }
    }
}
