using System.Threading.Tasks;
using Abp.Application.Services;
using ClothesBox.Sessions.Dto;

namespace ClothesBox.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
