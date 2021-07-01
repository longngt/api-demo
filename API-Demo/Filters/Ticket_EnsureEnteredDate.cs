using API_Demo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Demo.Filters
{
    public class Ticket_EnsureEnteredDate : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
            var ticket = context.ActionArguments["ticket"] as Ticket;
            if (ticket != null && 
                !string.IsNullOrWhiteSpace(ticket.owner) && 
                ticket.enteredDate.HasValue == false)
            {
                context.ModelState.AddModelError("enteredDate", "Entered Date is required");
                context.Result = new BadRequestObjectResult(context.ModelState);
            }
        }
    }
}
