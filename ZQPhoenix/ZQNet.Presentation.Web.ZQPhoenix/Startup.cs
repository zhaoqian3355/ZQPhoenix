using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZQNet.Presentation.Web.ZQPhoenix.Startup))]
namespace ZQNet.Presentation.Web.ZQPhoenix
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
