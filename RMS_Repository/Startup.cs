using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RMS_Repository.Startup))]
namespace RMS_Repository
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
