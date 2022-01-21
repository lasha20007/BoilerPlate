using Abp.AutoMapper;
using ClothesBox.Sessions.Dto;

namespace ClothesBox.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}