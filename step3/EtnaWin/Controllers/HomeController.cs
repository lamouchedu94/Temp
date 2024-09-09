using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("home")]
public class HomeController : ControllerBase
{
    [HttpGet("hello")]
    public IActionResult Get()
    {
        return Ok(new { etna = "Hello World" });
    }
}
