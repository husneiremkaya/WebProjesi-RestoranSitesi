using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebProje
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
              name: "About",
              url: "Hakkimizda",
              defaults: new { controller = "About", action = "Index" }
          );
            routes.MapRoute(
               name: "Gallery",
               url: "Galeri",
               defaults: new { controller = "Gallery", action = "Index"}
           );
            routes.MapRoute(
               name: "Reservation",
               url: "Rezervasyon",
               defaults: new { controller = "Reservation", action = "Index"}
           );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
