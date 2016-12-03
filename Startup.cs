using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExamProject1._1.Startup))]
namespace ExamProject1._1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
