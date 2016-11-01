using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EjemploPersona.Startup))]
namespace EjemploPersona
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
