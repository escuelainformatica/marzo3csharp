using Marzo3.modelo;
using Marzo3.servicio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CalculadoraSrv srv = new CalculadoraSrv();
            Calculadora calc = srv.Factory(5, 5);
            Assert.AreEqual(10, srv.Sumar(calc));

            calc = srv.Factory(5, 20);
            Assert.AreEqual(25, srv.Sumar(calc));

            calc = srv.Factory(0, 0);
            Assert.AreEqual(0, srv.Sumar(calc));

            calc = srv.Factory(10, 2);
            Assert.AreEqual(8, srv.Restar(calc));

            //calc = srv.Factory(Decimal.MaxValue, Decimal.MaxValue);
            //Assert.AreEqual(20, srv.Multiplicar(calc));

            calc = srv.Factory(10, 2);
            Assert.AreEqual(5, srv.Dividir(calc));

            calc = srv.Factory(10, 0);
            Assert.AreEqual(0, srv.Dividir(calc));
        }
    }
}
