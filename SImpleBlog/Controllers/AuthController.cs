using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SImpleBlog.ViewModels;

namespace SImpleBlog.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(AuthLogin form)
        {
            if (!ModelState.IsValid) return View(form);
            return Content("Hi " + form.Username);
        }
    }
}