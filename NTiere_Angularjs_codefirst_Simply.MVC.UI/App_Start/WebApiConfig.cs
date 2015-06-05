using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace NTiere_Angularjs_codefirst_Simply.MVC.UI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
