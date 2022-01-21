using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ClothesBox.Roles.Dto;
using ClothesBox.Users.Dto;

namespace ClothesBox.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}