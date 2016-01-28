using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Evaluación_Giovanni_Crescencio_Ahuactzi.Startup))]
namespace Evaluación_Giovanni_Crescencio_Ahuactzi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
