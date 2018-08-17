using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(facesesame.Startup))]
namespace facesesame
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
