using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Grptwomvc.Startup))]
namespace Grptwomvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
