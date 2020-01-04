using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FarmBazar.Web.Startup))]
namespace FarmBazar.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
