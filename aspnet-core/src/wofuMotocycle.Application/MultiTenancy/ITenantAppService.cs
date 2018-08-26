using Abp.Application.Services;
using Abp.Application.Services.Dto;
using wofuMotocycle.MultiTenancy.Dto;

namespace wofuMotocycle.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
