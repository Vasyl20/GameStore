using GameStore.Helper;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GameStore.Startup))]
namespace GameStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            //SeederDatabase.SeedData();
        }
    }
}
