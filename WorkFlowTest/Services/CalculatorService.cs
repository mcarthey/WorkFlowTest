namespace WorkFlowTest.Services
{
    public class CalculatorService : ICalculatorService
    {
        public int Add(int x, int y) 
        {
            return x+y;
        }
    }
}