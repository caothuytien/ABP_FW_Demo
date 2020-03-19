using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace NewDemo.EntityFrameworkCore
{
    public static class NewDemoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<NewDemoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<NewDemoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
