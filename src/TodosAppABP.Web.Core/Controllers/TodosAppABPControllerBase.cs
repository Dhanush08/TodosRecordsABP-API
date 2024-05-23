using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace TodosAppABP.Controllers
{
    public abstract class TodosAppABPControllerBase: AbpController
    {
        protected TodosAppABPControllerBase()
        {
            LocalizationSourceName = TodosAppABPConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
