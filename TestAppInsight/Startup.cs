using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestAppInsight.Startup))]
namespace TestAppInsight
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
