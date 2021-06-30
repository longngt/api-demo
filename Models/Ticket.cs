using Microsoft.AspNetCore.Mvc;

namespace api_demo.Models
{
    public class Ticket
    {

        public int TicketId { get; set; }

        public int ProjectId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }
}