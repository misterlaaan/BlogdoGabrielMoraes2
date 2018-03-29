using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlogdoGabrielMoraes.Startup))]
namespace BlogdoGabrielMoraes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
