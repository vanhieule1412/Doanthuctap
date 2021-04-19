using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace doanthuctap.Controllers
{
    public class DienKeController : Controller
    {
        private Models.tinhtiendienEntities1 dc = new Models.tinhtiendienEntities1();
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
    }
}