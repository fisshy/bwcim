using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bwcim.Startup))]
namespace Bwcim
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
