using api_demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace api_demo.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ProjectsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Get all the projects");
        }
        [HttpGet("{id}")]

        public IActionResult Get(int id)
        {

            return Ok($"Reading project #{id}");
        }

        [HttpGet]
        [Route("/api/projects/{pid}/tickets")]
        public IActionResult GetProjectTicket(int pid, [FromQuery] int tid)
        {
            // if (tid == null)
            // {
            //     return BadRequest("Params are not provided properly");
            // }

            return Ok($"Reading project #{pid}, ticket #{tid}");
        }

        [HttpPost]

        public IActionResult Post()
        {
            return Ok("Creating a project");
        }

        [HttpPut("{id}")]

        public IActionResult Put(int id)
        {
            return Ok($"Updating project #{id}");
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            return Ok($"Deleting project #{id}");
        }
    }
}