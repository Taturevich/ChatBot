using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AimlBotWeb.Startup))]
namespace AimlBotWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
