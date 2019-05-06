using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CarNew
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(name: "Logout", url: "logout",
                defaults: new { controller = "User", action = "Logout" }
            );
            routes.MapRoute(name: "Login", url: "login",
                defaults: new { controller = "User", action = "Login" , id=UrlParameter.Optional}
            );
            routes.MapRoute(name: "Register", url: "register",
                defaults: new { controller = "User", action = "Register" }
            );
            routes.MapRoute(name: "Rent", url: "rent",
                defaults: new { controller = "Rent", action = "Index"}
            );
            routes.MapRoute(name: "Schedule", url: "schedule",
                defaults: new { controller = "Schedule", action = "Index", type = "promotion" }
            );
            routes.MapRoute(name: "Maintenance", url: "maintenance",
                defaults: new { controller = "Maintenance", action = "Index", type = "promotion" }
            );
            routes.MapRoute(name: "Statistic", url: "statistic",
                defaults: new { controller = "Statistic", action = "Index", type = "promotion" }
            );

            routes.MapRoute(
                name: "Default",
                url: "",
                defaults: new { controller = "Default", action = "Index" }
            );
        }
    }
}
