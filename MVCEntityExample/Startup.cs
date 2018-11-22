using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCEntityExample.Startup))]
namespace MVCEntityExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
