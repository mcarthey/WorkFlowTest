using System;
using Microsoft.Extensions.DependencyInjection;
using WorkFlowTest.Services;

namespace WorkFlowTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = Startup.Configure();
            var service = serviceProvider.GetService<ICalculatorService>();

            service.EnterValues();
            var answer = service.Add();

            System.Console.WriteLine($"Your answer is: {answer}");
        }
    }
}
