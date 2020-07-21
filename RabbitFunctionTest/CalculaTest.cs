using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumerosPrimosFunction;

namespace RabbitFunctionTest
{
    [TestClass]
    public class CalculaTest
    {
        [TestMethod]
        public void CalculaNumerosPrimos_no_devuelve_null()
        {
            var resultado = Calcula.TiempoNumeroTotal(0);
            Assert.IsNotNull(resultado);       
        }

        [TestMethod]
        public void CalculaNumerosPrimos_los_primeros_30_y_devuelve_29()
        {
            var numerosMax = 30;
            var resultado = Calcula.TiempoNumeroTotal(numerosMax);

            Assert.AreEqual(29, resultado.ultimoPrimo);
        }

        [TestMethod]
        public void CalculaNumerosPrimos_numeros_primos_y_el_timeSpan_es_mayor_de_0()
        {
            var numerosMax = 10;
            var resultado = Calcula.TiempoNumeroTotal(numerosMax);

            Assert.IsTrue(resultado.tiempoTotal.TotalMilliseconds > 0);
        }
    }
}
