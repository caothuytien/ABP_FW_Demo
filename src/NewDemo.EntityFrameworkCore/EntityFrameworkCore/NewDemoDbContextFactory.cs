using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using NewDemo.Configuration;
using NewDemo.Web;

namespace NewDemo.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class NewDemoDbContextFactory : IDesignTimeDbContextFactory<NewDemoDbContext>
    {
        public NewDemoDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<NewDemoDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            NewDemoDbContextConfigurer.Configure(builder, configuration.GetConnectionString(NewDemoConsts.ConnectionStringName));

            return new NewDemoDbContext(builder.Options);
        }
    }
}
