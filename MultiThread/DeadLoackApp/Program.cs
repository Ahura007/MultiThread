using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DeadLoackApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //   CreateHostBuilder(args).Build().Run();
            MainAsync().Wait();
            Console.ReadLine();
        }


        private static Task MainAsync()
        {
            GetSampleString().Wait();
            return Task.CompletedTask;
        }

        private static async Task<string> GetSampleString()
        {
            await Task.Delay(2000);
            return "configure await result";
        }


        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
