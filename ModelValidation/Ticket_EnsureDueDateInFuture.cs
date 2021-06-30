using System;
using System.ComponentModel.DataAnnotations;
using api_demo.Models;

namespace api_demo.ModelValidation
{
    public class Tick_EnsureDueDateInFuture : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var ticket = validationContext.ObjectInstance as Ticket;
            if (ticket != null && !string.IsNullOrWhiteSpace(ticket.Owner))
            {
                if (ticket.DueDate.HasValue && ticket.DueDate.Value < DateTime.Now)
                {
                    return new ValidationResult("Due date is expired!");
                }
            }
            return ValidationResult.Success;
        }
    }
}