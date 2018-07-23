using Roomy.Areas.BackOffice.Models;
using Roomy.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Roomy.Utils;


namespace Roomy.Areas.BackOffice.Controllers
{
    public class AuthenticationController : Controller
    {
        private RoomyJessyDbContext db = new RoomyJessyDbContext();
        // GET: BackOffice/Authentication/Login
        public ActionResult Login()
        {
            return View();
        }

        // POST: BackOffice/Authentication/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(AuthenticationLoginViewModels model)
        {
            var passwordHash = model.Password.HashMD5();
            var user = db.Users.SingleOrDefault(x => x.Mail == model.Login && x.Password ==passwordHash);
            if (user == null)
            {
                return RedirectToAction("Login");
            }
            else
            {
                Session.Add("USER_BO", user);
                return RedirectToAction("Index", "Dashboard", new { area = "BackOffice" });
            }
        }

        // GET: BackOffice/Authentication/Logout
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home", new { area = "" }); 
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }

}