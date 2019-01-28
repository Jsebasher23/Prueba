using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Prueba.Backend.Startup))]
namespace Prueba.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
