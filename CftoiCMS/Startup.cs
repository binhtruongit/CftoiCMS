using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CftoiCMS.Startup))]
namespace CftoiCMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
