using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamApp.Startup))]
namespace TeamApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
