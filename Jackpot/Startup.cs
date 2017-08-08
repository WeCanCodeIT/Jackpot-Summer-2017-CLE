using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Jackpot.Startup))]
namespace Jackpot
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
