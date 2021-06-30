using api_demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace api_demo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketsController : ControllerBase
    {
        [HttpGet]

        public IActionResult Get()
        {
            return Ok("Reading all the tickets");
        }

        [HttpGet("{id}")]

        public IActionResult Get(int id)
        {

            return Ok($"Reading ticket #{id}");
        }

        [HttpPost]

        public IActionResult Post([FromBody] Ticket ticket)
        {

            return Ok(ticket);
        }

        [HttpPut("{id}")]

        public IActionResult Put(int id)
        {
            return Ok($"Updating ticket #{id}");
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            return Ok($"Deleting ticket #{id}");
        }
    }
}