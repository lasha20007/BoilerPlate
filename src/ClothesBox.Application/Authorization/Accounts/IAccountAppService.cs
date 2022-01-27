using System.Threading.Tasks;
using Abp.Application.Services;
using ClothesBox.Authorization.Accounts.Dto;

namespace ClothesBox.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
