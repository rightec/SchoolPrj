using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Start async Main Task.");
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");


            // Uri BaseAddress = new Uri("https://www.example.com/base");
            // string myLocalServerUri = "https://localhost:44392/";
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            // Console.WriteLine("Base Address is " + myLocalServerUri);

            // string baseAddressLog = builder.HostEnvironment.BaseAddress;

            /*
            if (baseAddressLog != " ")
            {
                Console.WriteLine("Base Address is ", baseAddressLog);
            } 
            else
            {
                Console.WriteLine("Base Address is ", BaseAddress.AbsoluteUri);
            }
            */

            await builder.Build().RunAsync();
        }
    }
}
