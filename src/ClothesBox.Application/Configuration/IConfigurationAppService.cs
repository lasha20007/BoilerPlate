using System.Threading.Tasks;
using Abp.Application.Services;
using ClothesBox.Configuration.Dto;

namespace ClothesBox.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}