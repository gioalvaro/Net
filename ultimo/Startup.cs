using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ultimo.Startup))]
namespace ultimo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
