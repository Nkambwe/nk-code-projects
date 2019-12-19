using System.Web.Mvc;
using System.Web.Routing;

namespace MvcFromEmptyProject {

    public class RouteConfig {

        public static void RegisterRoutes(RouteCollection routes)  {

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "InventoryByBatchNumber",
                "Inventory/Stocking/{category}/{batch}",
                new {controller ="Home", action="Stocking"},
                new { category=@"\d{4}", batch=@"\d{3}"});

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
