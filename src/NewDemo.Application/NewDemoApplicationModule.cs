using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NewDemo.Authorization;

namespace NewDemo
{
    [DependsOn(
        typeof(NewDemoCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class NewDemoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<NewDemoAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(NewDemoApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
