using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AddressValidation.Startup))]
namespace AddressValidation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
