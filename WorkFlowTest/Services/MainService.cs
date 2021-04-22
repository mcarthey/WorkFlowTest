using System;
using System.Threading.Tasks;

namespace WorkFlowTest.Services
{
    public class MainService : IMainService
    {
        private readonly ICalculatorService _calculatorService;

        public MainService(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }
        public Task Invoke()
        {
            Console.WriteLine("ENTER TWO NUMBERS");

            System.Console.Write("NUM1: ");
            var num1 = Convert.ToInt32(Console.ReadLine());

            System.Console.Write("NUM2: ");
            var num2 = Convert.ToInt32(Console.ReadLine());

            var answer = _calculatorService.Add(num1, num2);

            System.Console.WriteLine($"Your answer is: {answer}");

            return Task.FromResult(0);
        }
    }
}