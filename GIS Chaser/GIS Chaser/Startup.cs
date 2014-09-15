using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GIS_Chaser.Startup))]
namespace GIS_Chaser
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
