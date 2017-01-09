using System.Threading.Tasks;
using Abp.Application.Services;
using TaskList.Roles.Dto;

namespace TaskList.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
