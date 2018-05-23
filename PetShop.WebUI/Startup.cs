using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PetShop.WebUI.Startup))]
namespace PetShop.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
