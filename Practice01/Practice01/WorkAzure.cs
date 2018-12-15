using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Practice01
{
    public static class WorkAzure
    {
        [FunctionName("WorkAzure")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "naam/{number1}/{number2}")] HttpRequest req, int number1, int number2,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            int result = number1 + number2;

            if (result != null)
            {
                return new OkObjectResult(result);
            }
            else
            {
                return new StatusCodeResult(500);
            }
        }

        [FunctionName("DeelGetallen")]
        public static async Task<IActionResult> Delen(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "delen/{number1}/{number2}")]
            HttpRequest req, int number1, int number2,
            ILogger log)
        {
            double result = number1 / number2;

            if (result != null)
            {
                return new OkObjectResult("Het resultaat van de deling is:" + result);
            }
            else if (number2 == 0)
            {
                return new StatusCodeResult(500);
            }
            else
            {
                return new StatusCodeResult(500);
            }
        }
    }
}
