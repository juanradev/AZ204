using System;
using System.Threading.Tasks;
using Microsoft.Identity.Client;


namespace az204_authdemo
{
    class Program
    {


        private const string _clientId = "08a8ae18-a234-4cec-8ab8-63b174ab8666";
        private const string _tenantId = "03400c84-c523-.......................";

        public static async Task Main(string[] args)
        {
            var app = PublicClientApplicationBuilder
                .Create(_clientId)
                .WithAuthority(AzureCloudInstance.AzurePublic, _tenantId)
                .WithRedirectUri("http://localhost")
                .Build();

            string[] scopes = { "user.read" };
            AuthenticationResult result = await app.AcquireTokenInteractive(scopes).ExecuteAsync();

            Console.WriteLine($"Token:\t{result.AccessToken}");

        }
    }
}

