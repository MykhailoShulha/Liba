using Microsoft.EntityFrameworkCore;

using System.Data.Common;

namespace Biblioteka.EntityFrameworkCore
{
    public static class MySqlDemoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<BibliotekaDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<BibliotekaDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}
