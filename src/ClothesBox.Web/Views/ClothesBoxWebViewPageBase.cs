using Abp.Web.Mvc.Views;

namespace ClothesBox.Web.Views
{
    public abstract class ClothesBoxWebViewPageBase : ClothesBoxWebViewPageBase<dynamic>
    {

    }

    public abstract class ClothesBoxWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ClothesBoxWebViewPageBase()
        {
            LocalizationSourceName = ClothesBoxConsts.LocalizationSourceName;
        }
    }
}