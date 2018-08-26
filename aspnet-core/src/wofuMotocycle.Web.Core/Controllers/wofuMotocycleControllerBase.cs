using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace wofuMotocycle.Controllers
{
    public abstract class wofuMotocycleControllerBase: AbpController
    {
        protected wofuMotocycleControllerBase()
        {
            LocalizationSourceName = wofuMotocycleConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
