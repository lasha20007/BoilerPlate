using System.Threading.Tasks;
using Abp.Configuration.Startup;
using ClothesBox.Sessions;
using ClothesBox.Web.Views;
using Microsoft.AspNetCore.Mvc;

namespace ClothesBox.Web.Areas.Admin.Views.Shared.Components.RightNavbarUserArea
{
    public class RightNavbarUserAreaViewComponent : ClothesBoxViewComponent
    {
        private readonly ISessionAppService _sessionAppService;
        private readonly IMultiTenancyConfig _multiTenancyConfig;

        public RightNavbarUserAreaViewComponent(
            ISessionAppService sessionAppService,
            IMultiTenancyConfig multiTenancyConfig)
        {
            _sessionAppService = sessionAppService;
            _multiTenancyConfig = multiTenancyConfig;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = new RightNavbarUserAreaViewModel
            {
                LoginInformations = await _sessionAppService.GetCurrentLoginInformations(),
                IsMultiTenancyEnabled = _multiTenancyConfig.IsEnabled,
            };

            return View(model);
        }
    }
}

