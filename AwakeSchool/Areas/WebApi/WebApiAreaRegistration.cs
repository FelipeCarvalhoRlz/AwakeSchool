using System.Web.Http;
using System.Web.Mvc;

namespace AwakeSchool.Areas.WebApi
{
    public class WebApiAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "WebApi";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            //context.Routes.MapHttpRoute(
            //    "WebApi_default",
            //    "api/{controller}/{action}"
            //);
            
            context.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}