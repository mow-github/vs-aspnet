using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_06_49_auth.Startup))]
namespace _06_49_auth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
