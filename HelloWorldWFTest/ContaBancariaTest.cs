using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldWFTest
{
    [TestClass]
    public class ContaBancariaTest
    {
        [TestMethod]
        public void TestDebito()
        {
            ContaBancaria cb = new ContaBancaria("Márcio Lucas", 580.00);
            cb.Debito(80.00);
            Assert.AreEqual(500.00, cb.Saldo);
        }

        [TestMethod]
        public void TestCredito()
        {
            ContaBancaria cb = new ContaBancaria("Márcio Lucas", -580.00);
            cb.Credito(80.00);
            Assert.AreEqual(660.00, cb.Saldo);
        }
    }
}
