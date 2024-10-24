using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic; // List kullanmak için gerekli namespace

namespace TASK.Api.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/teams")]
    [ApiController]
    public class TeamV1Controller : ControllerBase
    {

        private readonly List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Sebuhi"},
            new Student { Id = 2, Name = "Aqil"},
            new Student { Id = 3, Name = "Aslan"}
        };
        [MapToApiVersion("1.0")]
        [HttpGet("v1")]
        public IActionResult GetAll()
        {
            return Ok(students);
        }
    }
}
