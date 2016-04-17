using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RoomRsvn.Startup))]
namespace RoomRsvn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
