using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSitebanHang.Models; 

namespace WebSitebanHang.Controllers
{
    public class KhachHangController : Controller
    {
        // GET: KhachHang
        QuanLyBanHangEntities2 db = new QuanLyBanHangEntities2();
        public ActionResult Index()
        {
            //C1 : Lấy dữ liệu từ 1 danh sách khách hàng
            //var lstKH = from KH in db.KhachHangs select KH;
            var lstKH = db.KhachHangs;
            return View(lstKH);
        }
        public ActionResult TruyVan1DoiTuong()
        {
            //Truy van 1 doi tuong
            //B1: Lay ra 1 danh sach khach hang
            var lstKH = from kh in db.KhachHangs where kh.MaKH == 1 select kh;
            //B2: 
            KhachHang khang = lstKH.FirstOrDefault();
            return View(khang);
        }
        public ActionResult SortDuLieu()
        {
            //Phương thức sắp xếp dữ liệu
            List<KhachHang> lstKH = db.KhachHangs.OrderByDescending(n => n.MaKH).ToList();
            return View(lstKH);
        }
        public ActionResult GroupDuLieu()
        {
            List<KhachHang> lstKH = db.KhachHangs.OrderByDescending(n => n.MaKH).ToList();
            return View(lstKH);
        }
    }
}