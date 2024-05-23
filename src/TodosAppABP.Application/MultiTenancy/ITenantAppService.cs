using Abp.Application.Services;
using TodosAppABP.MultiTenancy.Dto;

namespace TodosAppABP.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

