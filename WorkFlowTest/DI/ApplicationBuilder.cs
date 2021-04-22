using Microsoft.Extensions.Configuration;
using NLog;
using WorkFlowTest.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using NLog.Web;

namespace WorkFlowTest.DI
{
    public class ApplicationBuilder
    {
        private readonly Logger _logger = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();

        public IMainService Build()
        {
            _logger.Trace("Starting configuration.");

            var config = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            var serviceProvider = new ServiceCollection()
                .AddSingleton<ICalculatorService, CalculatorService>()
                .AddSingleton<IMainService, MainService>()
                .AddLogging(loggingBuilder =>
                {
                    // configure Logging with NLog
                    loggingBuilder.ClearProviders();
                    loggingBuilder.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
                    loggingBuilder.AddNLog(config);
                })
                .BuildServiceProvider();

            _logger.Trace("Finishing configuration.");

            return serviceProvider.GetService<IMainService>();
        }
    }
}
