using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace doanthuctap.Controllers
{
    public class KhachHangController : Controller
    {
        private Models.tinhtiendienEntities3 dc = new Models.tinhtiendienEntities3();
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

    }
}