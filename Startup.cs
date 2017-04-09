using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pluto_aurora.Startup))]
namespace pluto_aurora
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
