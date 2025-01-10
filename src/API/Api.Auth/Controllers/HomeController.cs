using Microsoft.AspNetCore.Mvc;

namespace API.Auth.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HomeController : ControllerBase
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public string Get()
    {
        return "hello auth";
    }
}
