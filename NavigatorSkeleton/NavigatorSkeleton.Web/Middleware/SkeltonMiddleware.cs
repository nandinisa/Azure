using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NavigatorSkeleton.Web.Middleware
{
    public class SkeltonMiddleware
    {
        Func<IDictionary<string, object>, Task> _next;
        public SkeltonMiddleware(Func<IDictionary<string, object>, Task> next)
        {
            _next = next;
        }

        public Task Invoke(IDictionary<string, object> environment)
        {
            var response = environment["owin.ResponseBody"] as Stream;
            using (var writer = new StreamWriter(response))
            {
                return writer.WriteAsync("Skelton Middleware");
            }

        }



    }
}