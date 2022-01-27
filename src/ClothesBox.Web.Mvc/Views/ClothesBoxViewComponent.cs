using Abp.AspNetCore.Mvc.ViewComponents;

namespace ClothesBox.Web.Views
{
    public abstract class ClothesBoxViewComponent : AbpViewComponent
    {
        protected ClothesBoxViewComponent()
        {
            LocalizationSourceName = ClothesBoxConsts.LocalizationSourceName;
        }
    }
}
