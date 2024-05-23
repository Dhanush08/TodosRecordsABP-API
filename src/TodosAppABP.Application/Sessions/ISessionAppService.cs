using System.Threading.Tasks;
using Abp.Application.Services;
using TodosAppABP.Sessions.Dto;

namespace TodosAppABP.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
