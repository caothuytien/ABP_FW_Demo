using System.Threading.Tasks;
using NewDemo.Configuration.Dto;

namespace NewDemo.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
