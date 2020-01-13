using System;
using Xunit;
using AzureAPI.Controllers;
using Microsoft.Extensions.Logging;

namespace AzureAPI.Tests
{
    public class UnitTest1
    {
        private ILogger<WeatherForecastController> _logger;

        [Fact]
        public void Test1()
        {

        }

        [Fact]
        public void GetReturnsCorrectWeather()
        {
            WeatherForecastController controller = new WeatherForecastController(_logger);

            var returnValue = controller.Get(1);
            Assert.Equal("Cool", returnValue.Value);
        }
    }
}
