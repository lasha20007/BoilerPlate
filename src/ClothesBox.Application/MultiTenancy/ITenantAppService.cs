using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ClothesBox.MultiTenancy.Dto;

namespace ClothesBox.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
