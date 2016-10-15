using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HarperSoftware.Web.Startup))]
namespace HarperSoftware.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
