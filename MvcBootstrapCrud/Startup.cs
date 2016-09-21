using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcBootstrapCrud.Startup))]
namespace MvcBootstrapCrud
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
