using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AG.Pos.EntityFrameworkCore
{
    public static class PosDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PosDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<PosDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}