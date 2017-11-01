using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldWF;

namespace HelloWorldWFTest
{

    [TestClass]
    public class TemperaturaCelciusTest
    {

        TemperaturaCelsius tc = new TemperaturaCelsius(29);

        [TestMethod]
        public void TestConverteCelsiusParaFirenight()
        {
            Assert.AreEqual(84.2, tc.converteCelsiusParaFahrenheit());
        }
        

    }
}
