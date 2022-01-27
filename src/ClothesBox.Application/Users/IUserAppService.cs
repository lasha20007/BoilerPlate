using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ClothesBox.Roles.Dto;
using ClothesBox.Users.Dto;

namespace ClothesBox.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task DeActivate(EntityDto<long> user);
        Task Activate(EntityDto<long> user);
        Task<ListResultDto<RoleDto>> GetRoles();
        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<bool> ChangePassword(ChangePasswordDto input);
    }
}
