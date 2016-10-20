using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleTwoPageApp.Startup))]
namespace SimpleTwoPageApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
