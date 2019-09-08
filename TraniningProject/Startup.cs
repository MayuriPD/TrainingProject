using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TraniningProject.Startup))]
namespace TraniningProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
