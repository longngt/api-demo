using API_Demo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_Demo.ModelValidations
{
    public class Ticket_DueDateValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var ticket = validationContext.ObjectInstance as Ticket;
            if (ticket != null && !string.IsNullOrWhiteSpace(ticket.owner))
            {
                if (!ticket.dueDate.HasValue)
                {
                    return new ValidationResult("Due date must be assigned when there is an owner");
                }
                if (ticket.dueDate.HasValue && ticket.dueDate.Value <= DateTime.Now)
                {
                    return new ValidationResult("Due date must be in the future");
                }
            }

            return ValidationResult.Success;

        }
    }
}
