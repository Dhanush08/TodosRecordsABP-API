using System.Threading.Tasks;
using TodosAppABP.Configuration.Dto;

namespace TodosAppABP.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
