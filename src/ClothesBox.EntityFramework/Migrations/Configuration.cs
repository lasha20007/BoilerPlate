using System.Data.Entity.Migrations;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using ClothesBox.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace ClothesBox.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<ClothesBox.EntityFramework.ClothesBoxDbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ClothesBox";
        }

        protected override void Seed(ClothesBox.EntityFramework.ClothesBoxDbContext context)
        {
            context.DisableAllFilters();

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //You can add seed for tenant databases and use Tenant property...
            }

            context.SaveChanges();
        }
    }
}
