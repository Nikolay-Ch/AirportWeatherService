using Microsoft.AspNetCore.Mvc;

namespace AirportWeatherService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SnowController : ControllerBase
{
    private readonly ILogger<SnowController> _logger;

    public SnowController(ILogger<SnowController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetSnow")]
    public bool Get()
    {
        bool isSnow = new Random(DateTime.Now.Nanosecond).NextDouble() > 0.8;

        _logger.LogInformation("Calling Snow with GET method... Returning: {isSnow}", isSnow);

        return isSnow;
    }
}
