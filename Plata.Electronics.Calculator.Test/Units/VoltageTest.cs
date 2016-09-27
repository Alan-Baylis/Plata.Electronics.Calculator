using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Plata.Electronics.Calculator.Units;

namespace Plata.Electronics.Calculator.Test.Units
{
    [TestClass]
    public class VoltageTest
    {
        [TestMethod]
        public void TestNameProperty()
        {
            Assert.AreEqual("Voltage", Voltage.Name);
        }

        [TestMethod]
        public void TestSymbolProperty()
        {
            Assert.AreEqual("v", Voltage.Symbol);
        }

        [TestMethod]
        public void TestToStringMethod()
        {
            Voltage voltage = new Voltage();
            voltage.Value = 110;

            Assert.AreEqual("110v", voltage.ToString());
        }

        [TestMethod]
        public void TestMakeMethod()
        {
            Voltage voltage = Voltage.make(220);

            Assert.AreEqual("220v", voltage.ToString());
        }
    }
}
