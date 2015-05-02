using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace RestauRaterService.App_Start
{
    public static class WebApiConfig
    {
        public const string DEFAULT_ROUTE_NAME = "MyDefaultRoute";
        public static void Register(HttpConfiguration config)
        {
            config.EnableCors();

            config.Routes.MapHttpRoute(
                name: DEFAULT_ROUTE_NAME,
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            
            config.EnableSystemDiagnosticsTracing();
        }
    }
}