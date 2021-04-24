using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace doanthuctap
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
        protected void Session_Start()
        {
            Session["dskh"] = new List<Models.KHANHHANG>();
            Session["DSgiadien"] = new List<Models.GIADIEN>();
            Session["dshd"] = new List<Models.KHANHHANG>();
        }
    }
}
