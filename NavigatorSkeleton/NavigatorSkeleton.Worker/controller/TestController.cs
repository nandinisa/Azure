using System.Net.Http;
using System.Web.Http;

namespace NavigatorSkeleton.Worker.controller
{
    public class TestController: ApiController
    {
        public HttpResponseMessage Get()
        {
            return new HttpResponseMessage()
            {
                Content = new StringContent("Hello from OWIN!")
            };
        }
    }
}
