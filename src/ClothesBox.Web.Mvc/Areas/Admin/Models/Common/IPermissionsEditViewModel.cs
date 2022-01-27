using System.Collections.Generic;
using ClothesBox.Roles.Dto;

namespace ClothesBox.Web.Areas.Admin.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}