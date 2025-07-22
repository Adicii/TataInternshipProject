using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProductApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
            name: "Default",
            url: "{controller}/{action}/{id}",
            defaults: new { controller = "Charts", action = "BugFrequencyChart", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Charts",
                url: "Home/Charts",
                defaults: new { controller = "Home", action = "Charts" }
             );

        }
    }
}
