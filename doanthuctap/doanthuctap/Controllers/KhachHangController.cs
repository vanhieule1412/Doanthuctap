using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace doanthuctap.Controllers
{
    public class KhachHangController : Controller
    {
        private Models.dienkeEntities3 dc = new Models.dienkeEntities3();
        // GET: KhachHang
        public ActionResult IndexKH()//lấy danh sách khách hàng từ csdl
        {
            return View(dc.KHANHHANGs.ToList());
        }
        public ActionResult Fromthemkhachhang()//hiện thị form thêm khách hàng
        {
            return View();
        }
        public ActionResult themkhachhang(Models.KHANHHANG kHANHHANG)//hàm xử lý thêm
        {
            if (ModelState.IsValid)
            {
                dc.KHANHHANGs.Add(kHANHHANG);
                dc.SaveChanges();
            }
            return RedirectToAction("IndexKH");//quay trở lại form IndexKH sau khi thêm xong
            //vậy là xong thêm
        }
        public ActionResult Formsuakhachhang(string id)
        {
            Models.KHANHHANG kHANHHANG = dc.KHANHHANGs.Find(id);
            return View(kHANHHANG);
        }
        public ActionResult suakhachhang(Models.KHANHHANG kHANHHANG)
        {
            Models.KHANHHANG HANHHANG = dc.KHANHHANGs.Find(kHANHHANG.Makh);
            if (HANHHANG != null)
            {
                HANHHANG.Makh = kHANHHANG.Makh;
                HANHHANG.Tenkh = kHANHHANG.Tenkh;
                HANHHANG.Dienthoai = kHANHHANG.Dienthoai;
                HANHHANG.Diachi = kHANHHANG.Diachi;
                HANHHANG.CMND = kHANHHANG.CMND;
                dc.SaveChanges();
            }
            return RedirectToAction("IndexKH");
        }
        public ActionResult Formxoakhachhang(string id)
        {
            Models.KHANHHANG kHANHHANG = dc.KHANHHANGs.Find(id);
            if (kHANHHANG != null)
            {
                return View(kHANHHANG);
            }
            return RedirectToAction("IndexKH");

        }
        public ActionResult xoakhachhang(string id)
        {
            Models.KHANHHANG kHANHHANG = dc.KHANHHANGs.Find(id);
            if (kHANHHANG != null)
            {
                dc.KHANHHANGs.Remove(kHANHHANG);
                dc.SaveChanges();
            }

            return RedirectToAction("IndexKH");

        }

    }
}