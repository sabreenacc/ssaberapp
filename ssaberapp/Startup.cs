using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ssaberapp.Startup))]
namespace ssaberapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
