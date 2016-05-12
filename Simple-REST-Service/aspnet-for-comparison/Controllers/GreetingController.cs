using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace aspnet_for_comparison.Controllers
{
    public class GreetingController : ApiController
    {
        private static long id = 0;

        public HttpResponseMessage Get(string name = "ASP.NET MVC World")
        {
            var content = new { id = ++id, content = "Hello, " + name };
            return Request.CreateResponse(HttpStatusCode.OK, content, JsonMediaTypeFormatter.DefaultMediaType);
        }
    }
}