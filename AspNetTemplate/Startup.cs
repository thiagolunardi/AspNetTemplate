using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspNetTemplate.Startup))]
namespace AspNetTemplate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
