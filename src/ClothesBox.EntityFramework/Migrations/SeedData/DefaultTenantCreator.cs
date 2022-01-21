using System.Linq;
using ClothesBox.EntityFramework;
using ClothesBox.MultiTenancy;

namespace ClothesBox.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly ClothesBoxDbContext _context;

        public DefaultTenantCreator(ClothesBoxDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
