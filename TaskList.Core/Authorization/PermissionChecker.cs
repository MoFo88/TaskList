using Abp.Authorization;
using TaskList.Authorization.Roles;
using TaskList.MultiTenancy;
using TaskList.Users;

namespace TaskList.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
