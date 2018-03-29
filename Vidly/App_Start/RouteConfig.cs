using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            /*
             * In order to use Attribute Routing We have to enable it
             * Using method -
             * routes.MapMvcAttributeRoutes();
             * Now, you can Attribute Routing as Convention Based Routing is Fragile
             */
            routes.MapMvcAttributeRoutes();

            /* routes.MapRoute(
                  "MoviesByReleaseDate", //Provides the name 
                  "Movies/Released/{year}/{month}", //Provides the url for routing
                  new { controller = "Movies", action = "ByReleaseDate"}, //Used for specifying constraints
                           new { year = @"\d{4}", month = @"\d{2}" } //Constraints
             );*/

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
