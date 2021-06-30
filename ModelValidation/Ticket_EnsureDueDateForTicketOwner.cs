using System.ComponentModel.DataAnnotations;
using api_demo.Models;

namespace api_demo.ModelValidation
{
    public class Tick_EnsureDueDateForTicketOwner : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var ticket = validationContext.ObjectInstance as Ticket;
            if (ticket != null && !string.IsNullOrWhiteSpace(ticket.Owner))
            {
                if (!ticket.DueDate.HasValue)
                {
                    return new ValidationResult("Required a date before assign to owner!");
                }
            }
            return ValidationResult.Success;
        }
    }
}