using System.Collections.Generic;
using ClothesBox.Roles.Dto;

namespace ClothesBox.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
