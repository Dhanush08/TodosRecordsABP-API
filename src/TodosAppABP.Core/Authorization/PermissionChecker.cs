using Abp.Authorization;
using TodosAppABP.Authorization.Roles;
using TodosAppABP.Authorization.Users;

namespace TodosAppABP.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
