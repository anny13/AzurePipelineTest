using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzurePipelineTest.Startup))]
namespace AzurePipelineTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
