using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IPMockup.Startup))]
namespace IPMockup
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
