using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Taakin.Api;

namespace Taakin.Host
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var contentRoot = Directory.GetCurrentDirectory();
            var webRoot = Path.Combine("..", "app");

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(contentRoot)
                .UseWebRoot(webRoot)
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
