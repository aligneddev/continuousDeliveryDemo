using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContinuousDelivery.Web.Startup))]
namespace ContinuousDelivery.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
