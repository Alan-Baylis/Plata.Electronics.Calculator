using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Plata.Electronics.Calculator.Units;

namespace Plata.Electronics.Calculator.Test
{
    [TestClass]
    public class OhmsLawTest
    {
        [TestMethod]
        public void TestVoltageCalculateMethod()
        {
            Current current = Current.make(2);
            Resistance resistance = Resistance.make(1000);

            Voltage voltage = OhmsLaw.calculate(current, resistance);

            Assert.AreEqual(2000, voltage.Value);
        }

        [TestMethod]
        public void TestCurrentCalculateMethod()
        {
            Voltage voltage = Voltage.make(5);
            Resistance resistance = Resistance.make(100);

            Current current = OhmsLaw.calculate(voltage, resistance);

            Assert.AreEqual(0.05F, current.Value);
        }

        [TestMethod]
        public void TestResistanceCalculateMethod()
        {
            Voltage voltage = Voltage.make(12);
            Current current = Current.make(0.5F);

            Resistance resistance = OhmsLaw.calculate(voltage, current);

            Assert.AreEqual(24F, resistance.Value);
        }
    }
}
