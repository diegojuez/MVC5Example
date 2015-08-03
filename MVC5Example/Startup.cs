using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5Example.Startup))]
namespace MVC5Example
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
