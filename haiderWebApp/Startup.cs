using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(haiderWebApp.Startup))]
namespace haiderWebApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
