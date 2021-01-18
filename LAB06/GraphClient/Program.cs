using System;
using Microsoft.Identity.Client;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Graph;    
using Microsoft.Graph.Auth;



namespace GraphClient
{
    public class Program
    {
        private const string _clientId = "eb75fab4-6ba8-45b0-a651-77479a48d909";
        private const string _tenantId = "03400c84-c523-4836-b6c0..............;
            
        public static async Task Main(string[] args)
        {
            var app = PublicClientApplicationBuilder
                .Create(_clientId)
                .WithAuthority(AzureCloudInstance.AzurePublic, _tenantId)
                .WithRedirectUri("http://localhost")
                .Build();
            List<string> scopes = new List<string> 
            { 
                "user.read" 
            };
            /* 
            ///  exercise 02
            var result = await app
                .AcquireTokenInteractive(scopes)
                .ExecuteAsync();
            Console.WriteLine($"Token:\t{result.AccessToken}");
            */
            DeviceCodeProvider provider = new DeviceCodeProvider(app, scopes);
            GraphServiceClient client = new GraphServiceClient(provider);

            User myProfile = await client.Me
                .Request()
                .GetAsync();
            Console.WriteLine($"Name:\t{myProfile.DisplayName}");
            Console.WriteLine($"AAD Id:\t{myProfile.Id}");

        }
    }
}