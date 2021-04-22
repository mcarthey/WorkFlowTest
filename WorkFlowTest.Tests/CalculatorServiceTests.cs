using Xunit;
using WorkFlowTest.Services;

namespace WorkFlowTest.Tests
{
    public class CalculatorServiceTests
    {
        [Fact]
        public void CalculatorService_Add_Success()
        {
            var service = new CalculatorService();

            var response = service.Add(1, 3);

            Assert.Equal(4, response);
        }

        [Fact]
        public void CalculatorService_Add_Failure()
        {
            var service = new CalculatorService();

            var response = service.Add(1, 3);

            Assert.NotEqual(3, response);
        }        
    }
}
