using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace NavigatorSkeleton.Worker
{
    public static class WebApiConfig
    {
        public static void Register(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            ConfigureRoutes(config);

            app.UseWebApi(config);
        }

        private static void ConfigureRoutes(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                   "Default",
                   "{controller}",
                   new { id = RouteParameter.Optional });
        }
    }
}
