using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetIFI.Startup))]
namespace ProjetIFI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
