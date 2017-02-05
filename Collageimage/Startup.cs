using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Collageimage.Startup))]
namespace Collageimage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
