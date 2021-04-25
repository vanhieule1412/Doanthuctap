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
        private Models.dienkeEntities2 dc = new Models.dienkeEntities2();
        // GET: laphoadon
        public ActionResult IndexHDL()
        {
            var table = new cthoadonviewmodel
            {
                Giadien = dc.GIADIENs.ToList(),
                CTHoadon = dc.CTHOADONs.ToList()
            };
            return View(table);
            
        }
   
    }
}