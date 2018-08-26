using System.Threading.Tasks;
using Abp.Application.Services;
using wofuMotocycle.Sessions.Dto;

namespace wofuMotocycle.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
