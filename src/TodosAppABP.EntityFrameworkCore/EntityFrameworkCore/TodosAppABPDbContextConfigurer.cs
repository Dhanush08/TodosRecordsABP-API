using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace TodosAppABP.EntityFrameworkCore
{
    public static class TodosAppABPDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TodosAppABPDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TodosAppABPDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
