using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using {Namespace}.Data.Repositories;

namespace {Namespace}.Data.PostgreSql;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<{PascalModuleName}DbContext>
{
    public {PascalModuleName}DbContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<{PascalModuleName}DbContext>();
        var connectionString = args.Length != 0 ? args[0] : "Server=localhost;Username=virto;Password=virto;Database=VirtoCommerce3;";

        builder.UseNpgsql(
            connectionString,
            options => options.MigrationsAssembly(typeof(PostgreSqlDataAssemblyMarker).Assembly.GetName().Name));

        return new {PascalModuleName}DbContext(builder.Options);
    }
}
