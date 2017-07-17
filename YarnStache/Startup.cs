using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YarnStache.Startup))]
namespace YarnStache
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
