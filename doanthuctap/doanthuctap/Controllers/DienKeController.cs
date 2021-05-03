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
            ViewBag.DSkh = dc.KHACHHANGs.ToList();
            return View();
        }
        
        public ActionResult themdienke(Models.DIENKE dIENKE)
        {
            if (ModelState.IsValid)
            {
                Models.DIENKE matontai = dc.DIENKEs.Find(dIENKE.Madk);
                if (matontai != null)
                {
                    ModelState.AddModelError("Madk", "Đã có mã này");
                }
                else {
                    dc.DIENKEs.Add(dIENKE);
                    dc.SaveChanges();
                    return RedirectToAction("IndexDK");
                }
              
            }
            ViewBag.DSkh = dc.KHACHHANGs.ToList();
            return View("Formthemdienke");

        }
        public ActionResult Formsuadienke(string id)
        {
            
            ViewBag.DSkh = dc.KHACHHANGs.ToList(); 
            Models.DIENKE dIENKE = dc.DIENKEs.Find(id);
            return View(dIENKE);
        }
        [HttpPost]
        public ActionResult suadienke(Models.DIENKE dIENKE)
        {
            
            Models.DIENKE iENKE = dc.DIENKEs.Find(dIENKE.Madk);
            if (ModelState.IsValid)
            {
                iENKE.Makh = dIENKE.Makh;
                iENKE.Ngaysx = dIENKE.Ngaysx;
                iENKE.Ngaylap = dIENKE.Ngaylap;
                iENKE.Mota = dIENKE.Mota;
                iENKE.Trangthai = dIENKE.Trangthai;
                dc.SaveChanges();
                return RedirectToAction("IndexDK");
            }
            ViewBag.DSkh = dc.KHACHHANGs.ToList();
            return View("Formsuadienke");
           
        }
        public ActionResult Formxoadienke(string id)
        {
            bool coXoa = true;
            Models.DIENKE dIENKE = dc.DIENKEs.Find(id);
            foreach (var item in dc.CTHOADONs.Where(x => x.Madk == id))
            {
                coXoa = false;
                break;
            }
            ViewBag.Xoakh = coXoa;
            if (dIENKE != null)
            {
                return View(dIENKE);
            }
            return RedirectToAction("IndexDK");

        }
        public ActionResult xoakhachhang(string id)
        {
            Models.DIENKE dIENKE = dc.DIENKEs.Find(id);
            if (dIENKE != null)
            {
                dc.DIENKEs.Remove(dIENKE);
                dc.SaveChanges();
            }

            return RedirectToAction("IndexDK");

        }
    }
}