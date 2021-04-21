using System;
using Microsoft.Extensions.DependencyInjection;
using WorkFlowTest.Services;

namespace WorkFlowTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ICalculatorService, CalculatorService>()
                .BuildServiceProvider();
            var service = serviceProvider.GetService<ICalculatorService>();

            Console.WriteLine("ENTER TWO NUMBERS");
            
            System.Console.Write("NUM1: ");
            var num1 = Convert.ToInt32(Console.ReadLine());
            
            System.Console.Write("NUM2: ");
            var num2 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine($"Your answer is: {service.Add(num1,num2)}");
        }
    }
}
