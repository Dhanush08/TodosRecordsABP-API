using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using TodosAppABP.Configuration.Dto;

namespace TodosAppABP.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TodosAppABPAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
