using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using wofuMotocycle.Configuration;
using wofuMotocycle.Web;

namespace wofuMotocycle.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class wofuMotocycleDbContextFactory : IDesignTimeDbContextFactory<wofuMotocycleDbContext>
    {
        public wofuMotocycleDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<wofuMotocycleDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            wofuMotocycleDbContextConfigurer.Configure(builder, configuration.GetConnectionString(wofuMotocycleConsts.ConnectionStringName));

            return new wofuMotocycleDbContext(builder.Options);
        }
    }
}
