using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BeginningGit.Startup))]
namespace BeginningGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
