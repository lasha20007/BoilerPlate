using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ClothesBox.EntityFrameworkCore
{
    public static class ClothesBoxDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ClothesBoxDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ClothesBoxDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
