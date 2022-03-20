using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CollegeBasketballAnalytics.Startup))]
namespace CollegeBasketballAnalytics
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
