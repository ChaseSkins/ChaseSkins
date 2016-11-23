using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChaseSkin.Startup))]
namespace ChaseSkin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
