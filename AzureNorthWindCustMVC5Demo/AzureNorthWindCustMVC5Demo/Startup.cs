using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureNorthWindCustMVC5Demo.Startup))]
namespace AzureNorthWindCustMVC5Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
