using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace NewDemo.Controllers
{
    public abstract class NewDemoControllerBase: AbpController
    {
        protected NewDemoControllerBase()
        {
            LocalizationSourceName = NewDemoConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
