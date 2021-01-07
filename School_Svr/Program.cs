using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School_Svr.Data;

namespace School_Svr
{
    public class Program
    {
        public static void Main(string[] args)
        {

            using (var db = new SchoolContext())
            { 

                try
                {                   
                    DbInitializer.Initialize(db);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in init", ex);
                }

                // exec query
                PersonsServiceDB.BasicQuery("Fernando");


            } // using db

            CreateHostBuilder(args).Build().Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
