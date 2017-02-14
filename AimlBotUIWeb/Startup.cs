using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AimlBotUIWeb.Startup))]
namespace AimlBotUIWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
