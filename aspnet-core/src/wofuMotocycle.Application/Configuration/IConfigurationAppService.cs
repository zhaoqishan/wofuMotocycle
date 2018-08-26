using System.Threading.Tasks;
using wofuMotocycle.Configuration.Dto;

namespace wofuMotocycle.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
