using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NewDemo.Configuration;

namespace NewDemo.Web.Host.Startup
{
    [DependsOn(
       typeof(NewDemoWebCoreModule))]
    public class NewDemoWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public NewDemoWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(NewDemoWebHostModule).GetAssembly());
        }
    }
}
