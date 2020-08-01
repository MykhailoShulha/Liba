using Microsoft.EntityFrameworkCore;

namespace Biblioteka.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<BibliotekaDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for BibliotekaDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
