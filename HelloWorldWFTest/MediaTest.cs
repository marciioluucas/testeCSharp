using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldWFTest
{
    [TestClass]
    public class MediaTest
    {
        [TestMethod]
        public void TestSeAdicionaNotaProva()
        {
            int cont = 0;
            CalculaMedia cM = new CalculaMedia();
            cM.InserirNotaProva(10);
            cM.InserirNotaProva(5);
            cM.InserirNotaProva(8);
            cM.InserirNotaProva(8);
            Assert.AreEqual(4, cM.ContadorProvas);
        }

        [TestMethod]
        public void TestSeAdicionaPonto()
        {
            
            CalculaMedia cM = new CalculaMedia();
            cM.InserirNotaProva(5);
            cM.InserirNotaProva(8);
            cM.InserirNotaProva(8);
            cM.InserirNotaProva(9);
            cM.InserirPonto(1);
            cM.InserirPonto(1);
            cM.InserirPonto(1);
            cM.InserirPonto(1);
           

            Assert.AreEqual(4, cM.ContadorPontos);
        }

        [TestMethod]
        public void TestCalcularMedia()
        {
            
            CalculaMedia cM = new CalculaMedia();
            cM.InserirNotaProva(5);
            cM.InserirNotaProva(8);
            cM.InserirNotaProva(8);
            cM.InserirNotaProva(9);
            cM.InserirPonto(1);
            cM.InserirPonto(1);
            cM.InserirPonto(1);
            cM.InserirPonto(1);

            
            Assert.AreEqual(8.5m, cM.CalcularMedia());
        }


    }
}
