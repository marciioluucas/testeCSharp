using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldWF;

namespace HelloWorldWFTest
{
    [TestClass]
    public class OperacaoTest
    {
        int a = 5;
        int b = 6;
        Operacao o = new Operacao();


        [TestMethod]
        public void TestSomarInteiros()
        {
            Assert.AreEqual(11, o.soma(a, b));
        }

        [TestMethod]
        public void TestSubtraiInteiros()
        {
            Assert.AreEqual(-1, o.subtrai(a, b));
        }
    }
}
