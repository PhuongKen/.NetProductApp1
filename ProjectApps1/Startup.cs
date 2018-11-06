using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectApps1.Startup))]
namespace ProjectApps1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
