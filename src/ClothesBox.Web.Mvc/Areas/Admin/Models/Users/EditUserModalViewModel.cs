using System.Collections.Generic;
using System.Linq;
using ClothesBox.Roles.Dto;
using ClothesBox.Users.Dto;

namespace ClothesBox.Web.Areas.Admin.Models.Users
{
    public class EditUserModalViewModel
    {
        public UserDto User { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public bool UserIsInRole(RoleDto role)
        {
            return User.RoleNames != null && User.RoleNames.Any(r => r == role.NormalizedName);
        }
    }
}
