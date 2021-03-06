using System.Linq;
using System.Threading.Tasks;
using Abp.Localization;
using ClothesBox.Web.Views;
using Microsoft.AspNetCore.Mvc;

namespace ClothesBox.Web.Areas.Admin.Views.Shared.Components.AccountLanguages
{
    public class AccountLanguagesViewComponent : ClothesBoxViewComponent
    {
        private readonly ILanguageManager _languageManager;

        public AccountLanguagesViewComponent(ILanguageManager languageManager)
        {
            _languageManager = languageManager;
        }

        public Task<IViewComponentResult> InvokeAsync()
        {
            var model = new LanguageSelectionViewModel
            {
                CurrentLanguage = _languageManager.CurrentLanguage,
                Languages = _languageManager.GetLanguages().Where(l => !l.IsDisabled).ToList()
                .Where(l => !l.IsDisabled)
                .ToList(),
                CurrentUrl = Request.Path
            };

            return Task.FromResult(View(model) as IViewComponentResult);
        }
    }
}
