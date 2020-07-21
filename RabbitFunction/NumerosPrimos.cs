using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace NumerosPrimosFunction
{
    public static class NumerosPrimos
    {
        [FunctionName("NumerosPrimos")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            var tiempoUtilizado = Calcula.TiempoNumeroTotal(100000).tiempoTotal;
            var responseMessage = tiempoUtilizado.Minutes.ToString() + ":" + tiempoUtilizado.Seconds.ToString() + "." + tiempoUtilizado.Milliseconds.ToString();
            
            return new OkObjectResult(responseMessage);
        }
    }
}
