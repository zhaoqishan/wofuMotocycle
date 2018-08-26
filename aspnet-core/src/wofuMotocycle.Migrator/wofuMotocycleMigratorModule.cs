using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using wofuMotocycle.Configuration;
using wofuMotocycle.EntityFrameworkCore;
using wofuMotocycle.Migrator.DependencyInjection;

namespace wofuMotocycle.Migrator
{
    [DependsOn(typeof(wofuMotocycleEntityFrameworkModule))]
    public class wofuMotocycleMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public wofuMotocycleMigratorModule(wofuMotocycleEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(wofuMotocycleMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                wofuMotocycleConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(wofuMotocycleMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
