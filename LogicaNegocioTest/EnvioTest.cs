using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicaNegocio;

namespace LogicaNegocioTest
{
    [TestClass]
    public class EnvioTest
    {
        [TestMethod]
        public void TestCalcularValorTotalResConDescuento()
        {
            int precioEsperado = 10000;
            int precioLogicaNegocio = Envio.CalcularVentasDeCarne(4, 1, true);

            Assert.AreEqual(precioEsperado, precioLogicaNegocio);
        }

        [TestMethod]
        public void TestCalcularValorTotalResSinConDescuento()
        {
            int precioEsperado = 9600;
            int precioLogicaNegocio = Envio.CalcularVentasDeCarne(3, 1, false);

            Assert.AreEqual(precioEsperado, precioLogicaNegocio);
        }

        [TestMethod]
        public void TestCalcularValorTotalCerdoConDescuento()
        {
            int precioEsperado = 12000;
            int precioLogicaNegocio = Envio.CalcularVentasDeCarne(6,2, true);

            Assert.AreEqual(precioEsperado, precioLogicaNegocio);
        }

        [TestMethod]
        public void TestCalcularValorTotalCerdoSinDescuento()
        {
            int precioEsperado = 11200;
            int precioLogicaNegocio = Envio.CalcularVentasDeCarne(4, 2, false);

            Assert.AreEqual(precioEsperado, precioLogicaNegocio);
        }

        [TestMethod]
        public void TestCalcularValorTotalPolloConDescuento()
        {
            int precioEsperado = 28000;
            int precioLogicaNegocio = Envio.CalcularVentasDeCarne(8, 3, true);

            Assert.AreEqual(precioEsperado, precioLogicaNegocio);
        }
        [TestMethod]
        public void TestCalcularValorTotalPolloSinDescuento()
        {
            int precioEsperado = 16700;
            int precioLogicaNegocio = Envio.CalcularVentasDeCarne(4, 3, false);

            Assert.AreEqual(precioEsperado, precioLogicaNegocio);
        }

    }
}
