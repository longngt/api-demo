using System;
using System.ComponentModel.DataAnnotations;
using api_demo.ModelValidation;
using Microsoft.AspNetCore.Mvc;

namespace api_demo.Models
{
    public class Ticket
    {

        public int? TicketId { get; set; }
        [Required]
        public int? ProjectId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public string Owner { get; set; }
        [Tick_EnsureDueDateForTicketOwner]
        [Tick_EnsureDueDateInFuture]
        public DateTime? DueDate { get; set; }

    }
}