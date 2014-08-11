using Microsoft.Owin;
using NavigatorSkeleton.Worker;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[assembly: OwinStartup(typeof(Startup))]
namespace NavigatorSkeleton.Worker
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            WebApiConfig.Register(app);
            //app.UseSkeltonMiddleware();
        }
    }
}
