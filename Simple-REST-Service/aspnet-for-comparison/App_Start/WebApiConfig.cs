using System.Web.Http;

namespace aspnet_for_comparison
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "Hello",
                routeTemplate: "{controller}"
            );
        }
    }
}