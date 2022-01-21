using System.Collections.Generic;
using ClothesBox.Roles.Dto;
using ClothesBox.Users.Dto;

namespace ClothesBox.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}