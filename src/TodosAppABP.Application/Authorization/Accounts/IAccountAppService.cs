using System.Threading.Tasks;
using Abp.Application.Services;
using TodosAppABP.Authorization.Accounts.Dto;

namespace TodosAppABP.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
