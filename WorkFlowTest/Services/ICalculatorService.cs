namespace WorkFlowTest.Services
{
    public interface ICalculatorService
    {
        int Add(int x = 0, int y = 0);
        void EnterValues();
    }
}