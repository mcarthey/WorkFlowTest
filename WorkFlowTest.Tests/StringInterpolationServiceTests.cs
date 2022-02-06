using System;
using Moq;
using Xunit;
using WorkFlowTest.Services;
using WorkFlowTest.Utils;

namespace WorkFlowTest.Tests
{
    public class StringInterpolationServiceTests
    {
        private readonly DateTime _testDate = new DateTime(2019, 01, 22, 11, 01, 27);
        private readonly Mock<ISystemDate> _mockDate = new Mock<ISystemDate>();

        public StringInterpolationServiceTests()
        {
            _mockDate.Setup(x => x.Now).Returns(_testDate);
        }

        [Fact]
        public void StringInterpolationService_Number1_Success()
        {
            var service = new StringInterpolationService(_mockDate.Object);

            var response = service.Number1();

            Assert.Equal("                        January 22, 2019", response);
        }

    }
}
