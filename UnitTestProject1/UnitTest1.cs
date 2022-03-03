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
            Calculadora calc = srv.Factory(5, 5,5);
            Assert.AreEqual(15, srv.Sumar(calc));

            calc = srv.Factory(5, 20,5);
            Assert.AreEqual(30, srv.Sumar(calc));

            calc = srv.Factory(0, 0,0);
            Assert.AreEqual(0, srv.Sumar(calc));

            calc = srv.Factory(10, 2,2);
            Assert.AreEqual(6, srv.Restar(calc));

            //calc = srv.Factory(Decimal.MaxValue, Decimal.MaxValue);
            //Assert.AreEqual(20, srv.Multiplicar(calc));

            calc = srv.Factory(10, 2,5);
            Assert.AreEqual(1, srv.Dividir(calc));

            calc = srv.Factory(10, 5,0);
            Assert.AreEqual(0, srv.Dividir(calc));
        }
    }
}
