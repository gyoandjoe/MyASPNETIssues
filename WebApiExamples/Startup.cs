using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApiExamples.Startup))]
namespace WebApiExamples
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
