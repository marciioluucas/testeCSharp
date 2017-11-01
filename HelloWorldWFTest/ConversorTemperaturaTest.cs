using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldWF;

namespace HelloWorldWFTest
{
    [TestClass]
    public class ConversorTemperaturaTest
    {
       

        [TestMethod]
        public void TestConverteCelsiusParaFahrenheit()
        {
            Assert.AreEqual(84.2, ConversorTemperatura.converteCelsiusParaFahrenheit(29));
        }

        [TestMethod]
        public void TestConverteFirenightToCelsius()
        {
            Assert.AreEqual(29, ConversorTemperatura.converteFahrenheitParaCelsius(84.2));
        }

    }
}
