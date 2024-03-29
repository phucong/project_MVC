﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ChessResult.Site
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
               name: "Default",
               url: "admin/{controller}/{action}/{id}",
               defaults: new { controller = "Tournament", action = "Index", id = UrlParameter.Optional }
           );
        }
    }
}
