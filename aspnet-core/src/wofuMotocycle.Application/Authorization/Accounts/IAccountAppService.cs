using System.Threading.Tasks;
using Abp.Application.Services;
using wofuMotocycle.Authorization.Accounts.Dto;

namespace wofuMotocycle.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
