using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QLBANXE.Startup))]
namespace QLBANXE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
