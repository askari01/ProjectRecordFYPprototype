using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectRecord.Startup))]
namespace ProjectRecord
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
