using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Hunerli
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
            if (Application["OnlineUsers"]==null)
            {
                int sayac = 1;
                Application["OnlineUsers"] = sayac;
            }
            else
            {
                int sayac = (int)Application["OnlineUsers"];
                sayac++;
                Application["OnlineUsers"] = sayac;
            }
            if (Application["TotalUsers"] == null)
            {
                int sayac = 1;
                Application["TotalUsers"] = sayac;
            }
            else
            {
                int sayac = (int)Application["TotalUsers"];
                sayac++;
                Application["TotalUsers"] = sayac;

            }
        }
        protected void Session_End()
        {
            int sayac = (int)Application["OnlineUsers"];
            sayac--;
            Application["OnlineUsers"] = sayac;
        }
    }
}
