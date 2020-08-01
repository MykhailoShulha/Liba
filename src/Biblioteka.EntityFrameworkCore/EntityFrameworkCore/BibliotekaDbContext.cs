using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Biblioteka.EntityFrameworkCore
{
    public class BibliotekaDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public BibliotekaDbContext(DbContextOptions<BibliotekaDbContext> options) 
            : base(options)
        {

        }
    }
}
