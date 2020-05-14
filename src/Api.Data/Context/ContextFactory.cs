using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            //MYSQL
            //var connectionString = "Server=localhost;Port=3306;Database=dbApi;Uid=root;Pwd=DS7.MySql";
            //SQL SERVER
            var connectionString = "Server=DSDEVWIN;Database=dbApi;User Id=webuserdev;Password=WEBuserdev#";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();

            //optionsBuilder.UseMySql(connectionString);
            optionsBuilder.UseSqlServer(connectionString);
            return new MyContext(optionsBuilder.Options);
        }
    }
}
