using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SecondAttempt.Startup))]
namespace SecondAttempt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
