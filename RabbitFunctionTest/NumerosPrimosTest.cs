using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumerosPrimosFunction;
using System.Net;

namespace NumerosPrimosFunctionTest
{
    [TestClass]
    public class NumerosPrimosTest
    {
        //[TestMethod]
        public void NumerosPrimos_devuelve_200()
        {
            var url = "https://azurespain.azurewebsites.net/";

            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Method = "GET";
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            var statusCode = response.StatusCode;
            response.Close();

            Assert.AreEqual(HttpStatusCode.OK, statusCode);
        }
    }
}
