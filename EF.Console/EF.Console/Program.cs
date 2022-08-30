using CommandLine;
using Microsoft.Extensions.Configuration;
using Serilog;
using System.IO;

namespace EF.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            var build = new ConfigurationBuilder();

            // Config appsettings
            build.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            // Config logger
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(build.Build())
                .WriteTo.Console()
                .CreateLogger();

            // Config parâmetros
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed(opts =>
                {
                    Log.Logger.Information($"{opts.requisicoes}");
                    Log.Logger.Information($"{opts.host}");
                });

            Log.Logger.Information("Fim da aplicação");
        }
    }
}
