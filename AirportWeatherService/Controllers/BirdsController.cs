using Microsoft.AspNetCore.Mvc;

namespace AirportWeatherService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BirdsController : ControllerBase
{
    private readonly ILogger<BirdsController> _logger;

    public BirdsController(ILogger<BirdsController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetBirds")]
    public bool Get()
    {
        bool areBirds = new Random(DateTime.Now.Nanosecond).NextDouble() >= 0.5;

        _logger.LogInformation("Calling Birds with GET method... Returning: {areBirds}", areBirds);

        return areBirds;
    }
}
