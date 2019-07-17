using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Homework_7.Startup))]
namespace Homework_7
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
