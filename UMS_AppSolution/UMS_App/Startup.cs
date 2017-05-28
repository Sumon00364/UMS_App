using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UMS_App.Startup))]
namespace UMS_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
