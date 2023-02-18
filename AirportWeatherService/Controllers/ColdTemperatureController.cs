using Microsoft.AspNetCore.Mvc;

namespace AirportWeatherService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ColdTemperatureController : Controller
{
    private readonly ILogger<SnowController> _logger;

    public ColdTemperatureController(ILogger<SnowController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetColdTemperature")]
    public bool Get()
    {
        bool isColdTemperature = new Random(DateTime.Now.Nanosecond).NextDouble() > 0.7;

        _logger.LogInformation("Calling ColdTemperature with GET method... Returning: {isColdTemperature}", isColdTemperature);

        return isColdTemperature;
    }
}
