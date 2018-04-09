using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System;

namespace DotNetCoreWebApi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BuildWebHost(args).Run();
        }
        public static IWebHost BuildWebHost(string[] args) =>
             WebHost.CreateDefaultBuilder(args).UseKestrel().UseUrls("http://*:5000;http://localhost:5001;http://hostname:5002")
                 .UseStartup<Startup>()
                 .Build();
    }
}
