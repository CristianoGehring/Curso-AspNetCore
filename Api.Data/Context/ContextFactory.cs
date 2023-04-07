using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            // usado para crias as migrações
            var connectionString = "Server=localhost;Port=3308;Database=dbApi;Uid=root;Pwd=root";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext> ();
            optionsBuilder.UseMySql(connectionString);
            return new MyContext(optionsBuilder.Options);
        }
    }
}