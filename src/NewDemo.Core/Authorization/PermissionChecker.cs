using Abp.Authorization;
using NewDemo.Authorization.Roles;
using NewDemo.Authorization.Users;

namespace NewDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
