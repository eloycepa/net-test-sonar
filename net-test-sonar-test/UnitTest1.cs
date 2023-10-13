using net_test_sonar.Controllers;
using NUnit.Framework.Internal;

namespace net_test_sonar_test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task WeatherForecastGet1()
        {
            var testController = new WeatherForecastController();
            var result = await testController.Get();
            if (result != null)
            {
                Assert.True(result.Any());          }
            else
            {
                Assert.Fail("No ha devuelto el valor esperado");
            }
        }

        [Test]
        public async Task WeatherForecastGet2()
        {
            var testController = new WeatherForecastController();
            var result = await testController.Get();
            if (result != null)
            {
                Assert.True(result.Count() == 5);
            }
            else
            {
                Assert.Fail("No ha devuelto el valor esperado");
            }
        }
    }
}