using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HeTeKanBan.Startup))]
namespace HeTeKanBan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
