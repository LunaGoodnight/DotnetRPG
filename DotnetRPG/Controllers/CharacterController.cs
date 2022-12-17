
using Microsoft.AspNetCore.Mvc;

namespace DotnetRPG.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CharacterController : ControllerBase
{
    private static Character knight = new Character();

    public IActionResult Get()
    {
        return Ok(knight);
    }
}