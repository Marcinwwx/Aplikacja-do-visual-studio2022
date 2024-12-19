using Microsoft.AspNetCore.Mvc;

namespace MyEnhancedApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetWeather()
        {
            var weatherData = new[]
            {
                new { Date = "2024-12-19", TemperatureC = 5, Summary = "Cloudy" },
                new { Date = "2024-12-20", TemperatureC = 3, Summary = "Rainy" },
                new { Date = "2024-12-21", TemperatureC = -1, Summary = "Snowy" }
            };

            return Ok(weatherData);
        }
    }
}
