using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PSTEINAzureEventSystem.Startup))]
namespace PSTEINAzureEventSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
