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
            return View(dc.KHACHHANGs.ToList());
        }
        public ActionResult FindKH(string id)
        {
            return View(dc.KHACHHANGs.Where(x=>x.Tenkh.StartsWith(id)||id == null).ToList());
        }

        public ActionResult Fromthemkhachhang()//hiện thị form thêm khách hàng
        {
            return View();
        }
        [HttpPost]
        
        public ActionResult themkhachhang(Models.KHACHHANG kHACHHANG)//hàm xử lý thêm
        {
            if (ModelState.IsValid)
            {
                dc.KHACHHANGs.Add(kHACHHANG);
                dc.SaveChanges();
                return RedirectToAction("IndexKH");
            }
            //ModelState.AddModelError("Makh", "Chưa nhập mã khách hàng");
            return View("Fromthemkhachhang");
            //quay trở lại form IndexKH sau khi thêm xong
            //vậy là xong thêm
        }
        public ActionResult Formsuakhachhang(string id)
        {
            Models.KHACHHANG kHACHHANG = dc.KHACHHANGs.Find(id);
            return View(kHACHHANG);
        }
        public ActionResult suakhachhang(Models.KHACHHANG kHACHHANG)
        {
            Models.KHACHHANG hACHHANG = dc.KHACHHANGs.Find(kHACHHANG.Makh);
            if (hACHHANG != null)
            {
                        //hACHHANG.Makh = kHACHHANG.Makh;
                        hACHHANG.Tenkh = kHACHHANG.Tenkh;
                        hACHHANG.Dienthoai = kHACHHANG.Dienthoai;
                        hACHHANG.Diachi = kHACHHANG.Diachi;
                        hACHHANG.CMND = kHACHHANG.CMND;
                        dc.SaveChanges();
                return RedirectToAction("IndexKH");

            }
            return View("Formsuakhachhang");
            
        }
        public ActionResult Formxoakhachhang(string id)
        {
            Models.KHACHHANG kHACHHANG = dc.KHACHHANGs.Find(id);
            if (kHACHHANG != null)
            {
                return View(kHACHHANG);
            }
            return RedirectToAction("IndexKH");

        }
        public ActionResult xoakhachhang(string id)
        {
            Models.KHACHHANG kHACHHANG = dc.KHACHHANGs.Find(id);
            if (kHACHHANG != null)
            {
                //foreach (var item in dc.DIENKEs.Where(x => x.Makh == id))
                //{
                //    ModelState.AddModelError("error", "ko thể xóa được");
                //}
                dc.KHACHHANGs.Remove(kHACHHANG);
                dc.SaveChanges();
            }

            return RedirectToAction("IndexKH");

        }

    }
}