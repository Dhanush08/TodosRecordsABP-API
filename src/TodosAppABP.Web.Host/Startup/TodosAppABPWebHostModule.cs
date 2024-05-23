using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TodosAppABP.Configuration;

namespace TodosAppABP.Web.Host.Startup
{
    [DependsOn(
       typeof(TodosAppABPWebCoreModule))]
    public class TodosAppABPWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public TodosAppABPWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TodosAppABPWebHostModule).GetAssembly());
        }
    }
}
