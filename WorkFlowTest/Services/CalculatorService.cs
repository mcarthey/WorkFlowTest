namespace WorkFlowTest.Services
{
    public class CalculatorService : ICalculatorService
    {
        public CalculatorService()
        {

        }

        public int Add(int x, int y)
        {
            return x + y;
        }

    }
}