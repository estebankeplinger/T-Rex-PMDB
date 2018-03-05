using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Portfolio_Management
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Adm_Prefix",
            //    url: "Adm_Prefix/{action}/{*id}",
            //    defaults: new { Controller = "Adm_Prefix" },
            //    constraints: new { id = @"\w.+" }

            //);
            routes.MapRoute(
                name: "Role",
                url: "Role/Edit/{Username}",
                defaults: new { controller = "Role", action = "Edit", Username = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
