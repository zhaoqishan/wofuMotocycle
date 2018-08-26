using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using wofuMotocycle.Roles.Dto;
using wofuMotocycle.Users.Dto;

namespace wofuMotocycle.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
