using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using AG.Pos.Configuration;
using AG.Pos.Web;

namespace AG.Pos.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class PosDbContextFactory : IDesignTimeDbContextFactory<PosDbContext>
    {
        public PosDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PosDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder(), addUserSecrets: true);

            PosDbContextConfigurer.Configure(builder, configuration.GetConnectionString(PosConsts.ConnectionStringName));

            return new PosDbContext(builder.Options);
        }
    }
}