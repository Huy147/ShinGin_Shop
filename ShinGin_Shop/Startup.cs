using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShinGin_Shop.Startup))]
namespace ShinGin_Shop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
