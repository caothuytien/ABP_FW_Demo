using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using NewDemo.Authorization.Roles;
using NewDemo.Authorization.Users;
using NewDemo.MultiTenancy;

namespace NewDemo.EntityFrameworkCore
{
    public class NewDemoDbContext : AbpZeroDbContext<Tenant, Role, User, NewDemoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public NewDemoDbContext(DbContextOptions<NewDemoDbContext> options)
            : base(options)
        {
        }
    }
}
