using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab2Asp.NetMVCViews.Startup))]
namespace Lab2Asp.NetMVCViews
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
