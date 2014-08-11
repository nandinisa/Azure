using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigatorSkeleton.Worker.middleware
{
    public class SkeletonMiddleware
    {
        Func<IDictionary<string, object>, Task> _next;
        public SkeletonMiddleware(Func<IDictionary<string, object>, Task> next)
        {
            _next = next;
        }

        public async Task Invoke(IDictionary<string, object> environment)
        {
            await _next(environment);
        }
    }
}
