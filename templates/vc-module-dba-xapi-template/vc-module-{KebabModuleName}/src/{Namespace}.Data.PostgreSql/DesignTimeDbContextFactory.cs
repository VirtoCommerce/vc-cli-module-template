using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using {Namespace}.Data.Repositories;

namespace {Namespace}.Data.PostgreSql;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<{ModuleName}DbContext>
{
    public {ModuleName}DbContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<{ModuleName}DbContext>();
        var connectionString = args.Length != 0 ? args[0] : "Server=localhost;Username=virto;Password=virto;Database=VirtoCommerce3;";

        builder.UseNpgsql(
            connectionString,
            options => options.MigrationsAssembly(typeof(PostgreSqlDataAssemblyMarker).Assembly.GetName().Name));

        return new {ModuleName}DbContext(builder.Options);
    }
}
