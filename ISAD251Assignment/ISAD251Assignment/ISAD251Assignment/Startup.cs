using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ISAD251Assignment.Startup))]
namespace ISAD251Assignment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
