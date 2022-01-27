using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ClothesBox.Configuration.Dto;

namespace ClothesBox.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ClothesBoxAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
