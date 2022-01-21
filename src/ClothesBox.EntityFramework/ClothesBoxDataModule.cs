using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using ClothesBox.EntityFramework;

namespace ClothesBox
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(ClothesBoxCoreModule))]
    public class ClothesBoxDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ClothesBoxDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
