using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ClothesBox.Authorization.Roles;
using ClothesBox.Authorization.Users;
using ClothesBox.MultiTenancy;

namespace ClothesBox.EntityFrameworkCore
{
    public class ClothesBoxDbContext : AbpZeroDbContext<Tenant, Role, User, ClothesBoxDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ClothesBoxDbContext(DbContextOptions<ClothesBoxDbContext> options)
            : base(options)
        {
        }
    }
}
