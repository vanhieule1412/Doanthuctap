using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace doanthuctap.Controllers
{
    public class DienKeController : Controller
    {
        private Models.dienkeEntities3 dc = new Models.dienkeEntities3();
        // GET: DienKe
        public ActionResult IndexDK()
        {
            return View(dc.DIENKEs.ToList());
        }
        public ActionResult Formthemdienke()
        {
            ViewBag.DSkh = dc.KHANHHANGs.ToList();
            return View();
        }
        
        public ActionResult themdienke(Models.DIENKE dIENKE)
        {
            if (ModelState.IsValid)
            {
                dc.DIENKEs.Add(dIENKE);
                dc.SaveChanges();
                return RedirectToAction("IndexDK");
            }
            ViewBag.DSkh = dc.KHANHHANGs.ToList();
            return View("Formthemdienke");

        }
        //public ActionResult Formsuakhachhang(string id)
        //{
        //    Models.KHANHHANG kHANHHANG = dc.KHANHHANGs.Find(id);
        //    return View(kHANHHANG);
        //}
        //public ActionResult suakhachhang(Models.KHANHHANG kHANHHANG)
        //{
        //    Models.KHANHHANG HANHHANG = dc.KHANHHANGs.Find(kHANHHANG.Makh);
        //    if (HANHHANG != null)
        //    {
        //        HANHHANG.Makh = kHANHHANG.Makh;
        //        HANHHANG.Tenkh = kHANHHANG.Tenkh;
        //        HANHHANG.Dienthoai = kHANHHANG.Dienthoai;
        //        HANHHANG.Diachi = kHANHHANG.Diachi;
        //        HANHHANG.CMND = kHANHHANG.CMND;
        //        dc.SaveChanges();
        //    }
        //    return RedirectToAction("IndexKH");
        //}
        //public ActionResult Formxoakhachhang(string id)
        //{
        //    Models.KHANHHANG kHANHHANG = dc.KHANHHANGs.Find(id);
        //    if (kHANHHANG != null)
        //    {
        //        return View(kHANHHANG);
        //    }
        //    return RedirectToAction("IndexKH");

        //}
        //public ActionResult xoakhachhang(string id)
        //{
        //    Models.KHANHHANG kHANHHANG = dc.KHANHHANGs.Find(id);
        //    if (kHANHHANG != null)
        //    {
        //        dc.KHANHHANGs.Remove(kHANHHANG);
        //        dc.SaveChanges();
        //    }

        //    return RedirectToAction("IndexKH");

        //}
    }
}