using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using wofuMotocycle.Authorization;

namespace wofuMotocycle
{
    [DependsOn(
        typeof(wofuMotocycleCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class wofuMotocycleApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<wofuMotocycleAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(wofuMotocycleApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
