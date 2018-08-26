using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace wofuMotocycle.EntityFrameworkCore
{
    public static class wofuMotocycleDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<wofuMotocycleDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<wofuMotocycleDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
