using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSitebanHang.Controllers
{
    public class DemoAjaxController : Controller
    {
        // GET: DemoAjax
        public ActionResult Index()
        {
            return View();
        }
        //Xử lý Ajax Action Link
        public ActionResult LoadAjaxActionLink()
        {
            return View();

        }
    }
}