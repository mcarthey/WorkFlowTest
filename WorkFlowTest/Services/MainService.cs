using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using NLog;
using NLog.Web;

namespace WorkFlowTest.Services
{
    public class MainService : IMainService
    {
        private readonly ICalculatorService _calculatorService;
        private readonly ILogger<MainService> _logger;

        public MainService(ICalculatorService calculatorService, ILogger<MainService> logger)
        {
            _calculatorService = calculatorService;
            _logger = logger;
        }
        public Task Invoke()
        {
            _logger.LogInformation("<Starting Main>");

            // MAIN LOGIC STARTS HERE
            Console.WriteLine("ENTER TWO NUMBERS");

            System.Console.Write("NUM1: ");
            var num1 = Convert.ToInt32(Console.ReadLine());

            System.Console.Write("NUM2: ");
            var num2 = Convert.ToInt32(Console.ReadLine());

            var answer = _calculatorService.Add(num1, num2);

            System.Console.WriteLine($"Your answer is: {answer}");
            // MAIN LOGIC ENDS HERE

            _logger.LogInformation("<Finishing Main>");
            return Task.FromResult(0);
        }
    }
}