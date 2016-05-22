using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestLOLApp.Startup))]
namespace TestLOLApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
