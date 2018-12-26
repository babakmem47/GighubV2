using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GighubV2.Startup))]
namespace GighubV2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
