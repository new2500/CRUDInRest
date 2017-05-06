using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRUDInRest_Client.Startup))]
namespace CRUDInRest_Client
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
