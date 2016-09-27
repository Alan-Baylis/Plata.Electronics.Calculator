using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Plata.Electronics.Calculator.Components.Resistors;

namespace Plata.Electronics.Calculator.Test.Components.Resistors
{
    [TestClass]
    public class ResistorTest
    {
        public Resistor makeFourBandResistor()
        {
            Band firstBand = new Band();
            Band secondBand = new Band();
            MultiplierBand thirdBand = new MultiplierBand();
            ToleranceBand fourthBand = new ToleranceBand();

            Resistor resistor = new Resistor();

            resistor.Bands.Add(firstBand);
            resistor.Bands.Add(secondBand);
            resistor.Bands.Add(thirdBand);
            resistor.Bands.Add(fourthBand);

            return resistor;
        }

        [TestMethod]
        public void TestResistorGetValueMethod()
        {
            Resistor resistor = makeFourBandResistor();

            ((Band)resistor.Bands[0]).Color = ResistorColor.Orange;
            ((Band)resistor.Bands[1]).Color = ResistorColor.Red;
            ((MultiplierBand)resistor.Bands[2]).Color = ResistorMultiplier.Brown;
            ((ToleranceBand)resistor.Bands[3]).Color = ResistorTolerance.Gold;

            Assert.AreEqual(320, resistor.Value);
        }

        [TestMethod]
        public void TestResistorFromFactoryMethod()
        {
            Resistor resistor = ResistorFactory.fourBands();

            ((Band)resistor.Bands[0]).Color = ResistorColor.Green;
            ((Band)resistor.Bands[1]).Color = ResistorColor.Black;
            ((MultiplierBand)resistor.Bands[2]).Color = ResistorMultiplier.Black;
            ((ToleranceBand)resistor.Bands[3]).Color = ResistorTolerance.Gold;

            Assert.AreEqual(50, resistor.Value);
        }

        [TestMethod]
        public void TestResistorFromFactoryWithParamMethod()
        {
            Band firstBand = new Band();
            Band secondBand = new Band();
            MultiplierBand thirdBand = new MultiplierBand();
            ToleranceBand fourthBand = new ToleranceBand();

            Resistor resistor = ResistorFactory.fourBands(firstBand, secondBand, thirdBand, fourthBand);

            ((Band)resistor.Bands[0]).Color = ResistorColor.Orange;
            ((Band)resistor.Bands[1]).Color = ResistorColor.Brown;
            ((MultiplierBand)resistor.Bands[2]).Color = ResistorMultiplier.Black;
            ((ToleranceBand)resistor.Bands[3]).Color = ResistorTolerance.Gold;

            Assert.AreEqual(31, resistor.Value);
        }
    }
}
