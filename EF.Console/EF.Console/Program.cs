using Microsoft.Extensions.Configuration;
using Serilog;
using System;
using System.IO;

namespace EF.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var build = new ConfigurationBuilder();

            build.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(build.Build())
                .WriteTo.Console()
                .CreateLogger();

            Log.Logger.Information("Information");
            Log.Logger.Warning("Warning");
            Log.Logger.Error("Error");
            Log.Logger.Fatal("Information");

            System.Console.ReadLine();
        }
    }
}
