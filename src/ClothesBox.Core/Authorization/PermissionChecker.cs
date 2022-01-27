using Abp.Authorization;
using ClothesBox.Authorization.Roles;
using ClothesBox.Authorization.Users;

namespace ClothesBox.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
