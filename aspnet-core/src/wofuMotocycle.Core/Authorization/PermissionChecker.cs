using Abp.Authorization;
using wofuMotocycle.Authorization.Roles;
using wofuMotocycle.Authorization.Users;

namespace wofuMotocycle.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
