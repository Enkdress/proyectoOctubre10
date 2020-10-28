using Microsoft.VisualStudio.TestTools.UnitTesting;
using MODELO.PROYECTO;
using System;

namespace CalculadoraTests
{
    [TestClass]
    public class TCalculadora
    {
        [TestMethod]
        public void Potencia()
        {
            double n1 = 10;
            double n2 = 5;
            MCalculadora mCalc = new MCalculadora(n1, n2);

            double result = mCalc.Potencia();
            double expected = 100000;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ValorAbsoluto()
        {
            double n1 = -10;
            double n2 = -5;
            MCalculadora mCalc = new MCalculadora(n1, n2);

            double result = mCalc.ValorAbsoluto();
            double expected = 5;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Factorial()
        {
            double n1 = 4;
            double n2 = 5;
            MCalculadora mCalc = new MCalculadora(n1, n2);

            double result = mCalc.Factorial();
            double expected = 24;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Serie1()
        {
            double n1 = 4;
            double n2 = 5;
            MCalculadora mCalc = new MCalculadora(n1, n2);

            String result = mCalc.Serie1();
            String expected = " 1 -2 3 -4 5";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AleatorioFacil()
        {
            double n1 = 1;
            double n2 = 5;
            MCalculadora mCalc = new MCalculadora(n1, n2);

            int result = mCalc.AleatorioFacil();

            Assert.IsTrue(result < n2 && result > n1);
        }
    }
}
