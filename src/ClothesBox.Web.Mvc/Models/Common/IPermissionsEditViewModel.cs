using System.Collections.Generic;
using ClothesBox.Roles.Dto;

namespace ClothesBox.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}