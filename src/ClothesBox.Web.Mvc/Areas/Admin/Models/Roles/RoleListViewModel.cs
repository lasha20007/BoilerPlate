using System.Collections.Generic;
using ClothesBox.Roles.Dto;

namespace ClothesBox.Web.Areas.Admin.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
