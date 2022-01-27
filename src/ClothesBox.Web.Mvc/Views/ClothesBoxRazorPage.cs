using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace ClothesBox.Web.Views
{
    public abstract class ClothesBoxRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected ClothesBoxRazorPage()
        {
            LocalizationSourceName = ClothesBoxConsts.LocalizationSourceName;
        }
    }
}
