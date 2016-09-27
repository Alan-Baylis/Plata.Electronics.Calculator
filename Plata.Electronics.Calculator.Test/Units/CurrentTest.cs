using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Plata.Electronics.Calculator.Units;

namespace Plata.Electronics.Calculator.Test.Units
{
    [TestClass]
    public class CurrentTest
    {
        [TestMethod]
        public void TestNameProperty()
        {
            Assert.AreEqual("Ampere", Current.Name);
        }

        [TestMethod]
        public void TestSymbolProperty()
        {
            Assert.AreEqual("A", Current.Symbol);
        }

        [TestMethod]
        public void TestToStringMethod()
        {
            Current current = new Current();
            current.Value = 0.5F;

            Assert.AreEqual("0.5A", current.ToString());
        }

        [TestMethod]
        public void TestMakeMethod()
        {
            Current current = Current.make(1);

            Assert.AreEqual("1A", current.ToString());
        }
    }
}
