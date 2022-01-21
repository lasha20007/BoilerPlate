using ClothesBox.EntityFramework;
using EntityFramework.DynamicFilters;

namespace ClothesBox.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly ClothesBoxDbContext _context;

        public InitialHostDbBuilder(ClothesBoxDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
