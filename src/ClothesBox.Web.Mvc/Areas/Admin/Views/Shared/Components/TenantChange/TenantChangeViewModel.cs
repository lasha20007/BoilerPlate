using Abp.AutoMapper;
using ClothesBox.Sessions.Dto;

namespace ClothesBox.Web.Areas.Admin.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
