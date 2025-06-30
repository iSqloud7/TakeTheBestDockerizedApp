using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TakeTheBest_Project.Startup))]
namespace TakeTheBest_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
