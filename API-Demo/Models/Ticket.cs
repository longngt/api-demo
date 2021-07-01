using API_Demo.ModelValidations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_Demo.Models
{
    public class Ticket
    {
        [Required]
        public int? id { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid email")]
        public string owner { get; set; }
        [Ticket_DueDateValidator]
        public DateTime? dueDate { get; set; }

        public DateTime? enteredDate { get; set; }
        [Required]
        public int? projectId { get; set; }

    }
}
