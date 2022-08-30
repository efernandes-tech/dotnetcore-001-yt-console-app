using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EF.Console
{
    public class Worker: BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IConfiguration _config;
        private readonly IProcesso _processo;

        public Worker(ILogger<Worker> logger, IConfiguration config, IProcesso processo)
        {
            _logger = logger;
            _config = config;
            _processo = processo;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while(!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation(_processo.getProcesso());

                await Task.Delay(TimeSpan.FromSeconds(3), stoppingToken);
            }

            await Task.Delay(TimeSpan.FromSeconds(1));
        }
    }
}
