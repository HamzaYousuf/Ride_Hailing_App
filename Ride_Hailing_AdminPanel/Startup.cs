using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ride_Hailing_AdminPanel.Startup))]
namespace Ride_Hailing_AdminPanel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
