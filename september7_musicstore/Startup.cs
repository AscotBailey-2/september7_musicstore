using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(september7_musicstore.Startup))]
namespace september7_musicstore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
