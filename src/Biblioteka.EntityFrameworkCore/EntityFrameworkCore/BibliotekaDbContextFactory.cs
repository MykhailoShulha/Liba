using Biblioteka.Configuration;
using Biblioteka.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Biblioteka.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class BibliotekaDbContextFactory : IDesignTimeDbContextFactory<BibliotekaDbContext>
    {
        public BibliotekaDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<BibliotekaDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(BibliotekaConsts.ConnectionStringName)
            );

            return new BibliotekaDbContext(builder.Options);
        }
    }
}