using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Roomy.Controllers
{
    public class SharedController : BaseController
    {
        //restreint la vue partielle. On ne peut pas appeler cette action et ce controller dans l'URL
        [ChildActionOnly]
        // GET: Shared
        public ActionResult TopFive()
        {
            var rooms = db.Rooms.OrderByDescending(x => x.Price).Take(5);


            return View("_TopFive",rooms);
        }
    }
}