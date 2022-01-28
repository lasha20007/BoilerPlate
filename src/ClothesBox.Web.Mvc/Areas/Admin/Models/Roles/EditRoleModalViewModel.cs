using Abp.AutoMapper;
using ClothesBox.Roles.Dto;
using ClothesBox.Web.Areas.Admin.Models.Common;

namespace ClothesBox.Web.Areas.Admin.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
