using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Botones.Startup))]
namespace Botones
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
