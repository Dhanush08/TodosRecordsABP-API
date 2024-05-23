using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TodosAppABP.EntityFrameworkCore;
using TodosAppABP.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace TodosAppABP.Web.Tests
{
    [DependsOn(
        typeof(TodosAppABPWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class TodosAppABPWebTestModule : AbpModule
    {
        public TodosAppABPWebTestModule(TodosAppABPEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TodosAppABPWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(TodosAppABPWebMvcModule).Assembly);
        }
    }
}