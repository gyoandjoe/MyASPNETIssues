using Microsoft.Owin;
using Owin;
using System.Web.Routing;


[assembly: OwinStartupAttribute(typeof(WebApiExamples.Startup))]
namespace WebApiExamples
{
    
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
