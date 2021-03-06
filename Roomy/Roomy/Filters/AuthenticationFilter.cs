﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Mvc;

namespace Roomy.Filters
{
    public class AuthenticationFilter: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
           if( filterContext.HttpContext.Session["USER_BO"]== null)
            {
                //on redirige avec des \\ avec l'area, le controller et l'action
                filterContext.Result = new RedirectResult("\\BackOffice\\Authentication\\Login");
            }
            
        }
    }
}