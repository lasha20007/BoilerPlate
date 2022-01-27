using System.Threading.Tasks;
using ClothesBox.Configuration.Dto;

namespace ClothesBox.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
