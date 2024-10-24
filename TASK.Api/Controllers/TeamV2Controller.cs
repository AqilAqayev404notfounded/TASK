using Microsoft.AspNetCore.Mvc;
using TASK.Api.Model;

namespace TASK.Api.Controllers;

[ApiVersion("2.0")]
[Route("api/v{version:apiVersion}/teams")]
[ApiController]
public class TeamV2Controller : ControllerBase
{
    private readonly List<Teacher> teachers = new List<Teacher>
        {
            new Teacher { Id = 1, Name = "Rafet"},
            new Teacher { Id = 2, Name = "Resul"},
            new Teacher { Id = 3, Name = "Abduleziz"}
        };
    [MapToApiVersion("2.0")]
    [HttpGet("v2")]
    public IActionResult GetAll()
    {
        return Ok(teachers);
    }
}
