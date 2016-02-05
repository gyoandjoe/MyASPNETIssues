using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CheckingASPNET.Startup))]
namespace CheckingASPNET
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
