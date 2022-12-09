using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using {Namespace}.Data.Repositories;

namespace {Namespace}.Data.SqlServer;

public class SqlServerDbContextFactory : IDesignTimeDbContextFactory<{ModuleName}DbContext>
{
    public {ModuleName}DbContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<{ModuleName}DbContext>();
        var connectionString = args.Any() ?
            args[0] :
            "Data Source=(local);Initial Catalog=VirtoCommerce3;Persist Security Info=True;User ID=virto;Password=virto;MultipleActiveResultSets=True;Connect Timeout=30";

        builder.UseSqlServer(
            connectionString,
            db => db.MigrationsAssembly(typeof(SqlServerDbContextFactory).Assembly.GetName().Name));

        return new {ModuleName}DbContext(builder.Options);
    }
}
