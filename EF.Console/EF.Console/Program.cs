using CommandLine;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
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

            // Config parâmetros (CommandParseLine)
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed(opts =>
                {
                    // Funcionamento em backgroud
                    var app = Host.CreateDefaultBuilder()
                        .ConfigureServices((context, services) =>
                        {
                            services.AddHostedService<Worker>();

                            // Injeção de dependência
                            services.AddTransient<IProcesso, Processo>();

                        })
                        .UseSerilog()
                        .Build();

                    app.Run();
                });

            Log.Logger.Information("Fim da aplicação");
        }
    }
}
