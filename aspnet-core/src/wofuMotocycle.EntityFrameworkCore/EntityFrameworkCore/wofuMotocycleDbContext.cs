using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using wofuMotocycle.Authorization.Roles;
using wofuMotocycle.Authorization.Users;
using wofuMotocycle.MultiTenancy;

namespace wofuMotocycle.EntityFrameworkCore
{
    public class wofuMotocycleDbContext : AbpZeroDbContext<Tenant, Role, User, wofuMotocycleDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public wofuMotocycleDbContext(DbContextOptions<wofuMotocycleDbContext> options)
            : base(options)
        {
        }
    }
}
