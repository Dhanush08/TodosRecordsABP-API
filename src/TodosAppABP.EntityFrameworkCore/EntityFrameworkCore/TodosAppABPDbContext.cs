using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TodosAppABP.Authorization.Roles;
using TodosAppABP.Authorization.Users;
using TodosAppABP.MultiTenancy;
using TodosAppABP.TodoRecords;

namespace TodosAppABP.EntityFrameworkCore
{
    public class TodosAppABPDbContext : AbpZeroDbContext<Tenant, Role, User, TodosAppABPDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Todo> TodoRecords { get; set; }

        public TodosAppABPDbContext(DbContextOptions<TodosAppABPDbContext> options)
            : base(options)
        {
        }
    }
}
