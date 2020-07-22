using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(learning_full_stack_developer_dotnet_framework.Startup))]
namespace learning_full_stack_developer_dotnet_framework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
