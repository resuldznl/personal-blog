using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.UI.Attributes
{
    public class AdminAuthFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            int? adminUserId = context.HttpContext.Session.GetInt32("adminUserId");
            if (adminUserId != null)
            { }
            else
            {
                context.Result = new RedirectToActionResult("Login", "Home", new { area = "AdminPanel" });
            }
            base.OnActionExecuting(context);
        }
    }
}
