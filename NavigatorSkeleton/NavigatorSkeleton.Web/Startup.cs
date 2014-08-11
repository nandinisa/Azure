using Microsoft.Owin;
using NavigatorSkeleton.Web;
using NavigatorSkeleton.Web.Middleware;
using Owin;

[assembly: OwinStartup(typeof(Startup))]

namespace NavigatorSkeleton.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Run(context =>
            {
                context.Response.ContentType = "text/plain";
                return context.Response.WriteAsync("Hello, world.");
            });
            
            
            app.UseSkeltonMiddleware();
        }
    }
}
