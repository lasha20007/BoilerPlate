using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ClothesBox.EntityFrameworkCore;
using ClothesBox.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ClothesBox.Web.Tests
{
    [DependsOn(
        typeof(ClothesBoxWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ClothesBoxWebTestModule : AbpModule
    {
        public ClothesBoxWebTestModule(ClothesBoxEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ClothesBoxWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ClothesBoxWebMvcModule).Assembly);
        }
    }
}