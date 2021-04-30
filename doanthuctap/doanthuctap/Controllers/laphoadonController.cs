using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using doanthuctap.Models;

namespace doanthuctap.Controllers
{
    public class laphoadonController : Controller
    {
        private Models.dienkeEntities3 dc = new Models.dienkeEntities3();
        // GET: laphoadon
        public ActionResult IndexHDL()
        {
            var table = new cthoadonviewmodel
            {
                Giadien = dc.GIADIENs.ToList(),
                CTHoadon = dc.CTHOADONs.ToList(),
                HoaDon =dc.HOADONs.ToList()
            };
            return View(table);
            
        }
   
    }
}