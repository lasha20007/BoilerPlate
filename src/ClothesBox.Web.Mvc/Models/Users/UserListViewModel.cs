using System.Collections.Generic;
using ClothesBox.Roles.Dto;

namespace ClothesBox.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
