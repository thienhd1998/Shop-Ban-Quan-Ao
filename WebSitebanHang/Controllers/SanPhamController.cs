using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSitebanHang.Models;

namespace WebSitebanHang.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: SanPham
        //Sử dụng partial view
        QuanLyBanHangEntities2 db = new QuanLyBanHangEntities2();
        public ActionResult SanPham1()
        {
            return View();
        }
        public ActionResult SanPham2()
        {
            return View();
        }
        //Tạo partial view
        public ActionResult SanPhamPartial()
        {
            return PartialView();
        }
    }
}