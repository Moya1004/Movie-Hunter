using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(odev3.Startup))]
namespace odev3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
