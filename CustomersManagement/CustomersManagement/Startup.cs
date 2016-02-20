using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomersManagement.Startup))]
namespace CustomersManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
