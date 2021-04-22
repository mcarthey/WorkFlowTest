using NLog;
using WorkFlowTest.Services;
using Microsoft.Extensions.DependencyInjection;

namespace WorkFlowTest.DI
{
    public class ApplicationBuilder
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public IMainService Build()
        {
            Logger.Trace("Starting Job configuration.");
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ICalculatorService, CalculatorService>()
                .AddSingleton<IMainService, MainService>()
                .BuildServiceProvider();

            Logger.Trace("Finishing Job configuration.");

            return serviceProvider.GetService<IMainService>();
        }
    }
}
