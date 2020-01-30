using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSitebanHang.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string name, string password)
        {
     
            if ("admin".Equals(name) && "tav".Equals(password))
            {
                Session["username"] = name;
                return RedirectToAction("Index", "Admin");
            }
            return View();
        }

    }
}
