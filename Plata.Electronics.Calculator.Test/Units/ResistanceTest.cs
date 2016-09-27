using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Plata.Electronics.Calculator.Units;

namespace Plata.Electronics.Calculator.Test.Units
{
    [TestClass]
    public class ResistanceTest
    {
        [TestMethod]
        public void TestNameProperty()
        {
            Assert.AreEqual("Ohm", Resistance.Name);
        }

        [TestMethod]
        public void TestSymbolProperty()
        {
            Assert.AreEqual("Ω", Resistance.Symbol);
        }

        [TestMethod]
        public void TestToStringMethod()
        {
            Resistance resistance = new Resistance();
            resistance.Value = 1200;

            Assert.AreEqual("1200Ω", resistance.ToString());
        }

        [TestMethod]
        public void TestMakeMethod()
        {
            Resistance resistance = Resistance.make(400);

            Assert.AreEqual("400Ω", resistance.ToString());
        }
    }
}
