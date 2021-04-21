using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using WorkFlowTest.Services;

namespace WorkFlowTest
{
    public static class Startup
    {
        public static ServiceProvider Configure()
        {
            return new ServiceCollection()
                .AddSingleton<ICalculatorService, CalculatorService>()
                .BuildServiceProvider();
        }
    }
}