using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ClothesBox.Controllers
{
    public abstract class ClothesBoxControllerBase: AbpController
    {
        protected ClothesBoxControllerBase()
        {
            LocalizationSourceName = ClothesBoxConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
