using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tres.Startup))]
namespace Tres
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
