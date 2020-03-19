using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using NewDemo.Configuration.Dto;

namespace NewDemo.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : NewDemoAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
