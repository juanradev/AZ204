using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace BlueYonder.Flights.GroupProxy
{
    public static class BookFlightFunc
    {
        [FunctionName("BookFlightFunc")]
        public static  IActionResult  Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request to the flights booking service.");

            var flightId = req.Query["flightId"];

            var flightServiceUrl = $"http://blueyonder-flights-jrdf.azurewebsites.net/api/flights/bookFlight?flightId={flightId}";

            log.LogInformation($"Flights service url:{flightServiceUrl}");

            var travelers = new List<Traveler>
            {
                new Traveler { Email = "204837Dazure@gmail.com" , FirstName = "Jonathan", LastName = "James", MobilePhone = "+61 0658748", Passport = "204837DCBA" },
                new Traveler { Email = "204837Dfunction@gmail.com", FirstName = "James", LastName = "Barkal", MobilePhone = "+61 0658355", Passport = "204837DCBABC" }
            };

            var travelersAsJson = JsonConvert.SerializeObject(travelers);

            using (var client = new HttpClient())
            {
                client.PostAsync(flightServiceUrl,
                                 new StringContent(travelersAsJson,
                                                   Encoding.UTF8,
                                                   "application/json")).Wait();
            }

            return (ActionResult)new OkObjectResult($"Request to book flight was sent successfully");
        }
    }
}
