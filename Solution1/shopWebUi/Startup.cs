using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(shopWebUi.Startup))]
namespace shopWebUi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
