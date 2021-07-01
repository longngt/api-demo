using API_Demo.Filters;
using API_Demo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Demo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [V1DiscontinueResource]
    public class TicketsController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetAllTickets()
        {
            return Ok("Get all tickets");
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetATicketById([FromRoute] int id)
        {
            return Ok($"Get ticket {id}");
        }

        [HttpPost]
        public IActionResult CreateATicketV1([FromBody] Ticket ticket)
        {

            return Ok(ticket);
        }

        [HttpPost]
        [Route("/api/v2/[controller]")]
        [Ticket_EnsureEnteredDate]
        public IActionResult CreateATicketV2([FromBody] Ticket ticket)
        {
            return Ok(ticket);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateATicketById([FromBody] Ticket ticket)
        {


            return Ok(ticket);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteATicketById([FromRoute] int id)
        {
            return Ok($"Delete ticket {id}");
        }
    }
}
