using Abp.Application.Services;
using ClothesBox.MultiTenancy.Dto;

namespace ClothesBox.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

