using System;

namespace WorkFlowTest.Services
{
    public class CalculatorService : ICalculatorService
    {
        public int Num1 { get; private set; }
        public int Num2 { get; private set; }

        public int Add(int x = 0, int y = 0) 
        {
            var val1 = x!=0 ? x : Num1;
            var val2 = y!=0 ? y : Num2;
            return val1+val2;
        }

        public void EnterValues()
        {
            Console.WriteLine("ENTER TWO NUMBERS");

            System.Console.Write("NUM1: ");
            Num1 = Convert.ToInt32(Console.ReadLine());

            System.Console.Write("NUM2: ");
            Num2 = Convert.ToInt32(Console.ReadLine());
        }        
    }
}