using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace {Namespace}.Data.Repositories
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<{ModuleName}DbContext>
    {
        public {ModuleName}DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<{ModuleName}DbContext>();

            builder.UseSqlServer("Data Source=(local);Initial Catalog=VirtoCommerce3;Persist Security Info=True;User ID=virto;Password=virto;MultipleActiveResultSets=True;Connect Timeout=30");

            return new {ModuleName}DbContext(builder.Options);
        }
    }
}
