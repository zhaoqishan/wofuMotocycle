using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using wofuMotocycle.Configuration;

namespace wofuMotocycle.Web.Host.Startup
{
    [DependsOn(
       typeof(wofuMotocycleWebCoreModule))]
    public class wofuMotocycleWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public wofuMotocycleWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(wofuMotocycleWebHostModule).GetAssembly());
        }
    }
}
