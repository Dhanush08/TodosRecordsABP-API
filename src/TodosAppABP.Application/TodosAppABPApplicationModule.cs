using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TodosAppABP.Authorization;

namespace TodosAppABP
{
    [DependsOn(
        typeof(TodosAppABPCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TodosAppABPApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<TodosAppABPAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(TodosAppABPApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
