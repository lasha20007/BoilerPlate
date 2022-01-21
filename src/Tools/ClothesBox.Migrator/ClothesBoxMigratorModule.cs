using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using ClothesBox.EntityFramework;

namespace ClothesBox.Migrator
{
    [DependsOn(typeof(ClothesBoxDataModule))]
    public class ClothesBoxMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<ClothesBoxDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}