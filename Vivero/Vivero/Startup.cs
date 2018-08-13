using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vivero.Startup))]
namespace Vivero
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
