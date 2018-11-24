using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UsineCreator.Startup))]
namespace UsineCreator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
