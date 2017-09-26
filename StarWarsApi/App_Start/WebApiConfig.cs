using StarWarsApi.ErrorHandler;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;

namespace StarWarsApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Services.Replace(typeof(IExceptionLogger), new AiExceptionLogger());
        }
    }
}
