using Microsoft.AspNetCore.Mvc;

namespace Skillclimb.Controllers;

[ApiController]
[Route("[controller]")]
public class PlaceholderController(ILogger<PlaceholderController> logger) : ControllerBase
{
    private readonly ILogger<PlaceholderController> _logger = logger;

    [HttpGet(Name = "GetPlaceholder")]
    public IActionResult Get()
    {
        return Ok(new { value = "Hello Skillclimb" });
    }
}
