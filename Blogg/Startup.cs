using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Blogg.Startup))]
namespace Blogg
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
