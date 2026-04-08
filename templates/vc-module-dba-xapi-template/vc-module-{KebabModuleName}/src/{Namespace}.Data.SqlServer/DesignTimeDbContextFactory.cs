using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using {Namespace}.Data.Repositories;

namespace {Namespace}.Data.SqlServer;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<{PascalModuleName}DbContext>
{
    public {PascalModuleName}DbContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<{PascalModuleName}DbContext>();
        var connectionString = args.Length != 0 ? args[0] : "Server=(local);User=virto;Password=virto;Database=VirtoCommerce3;";

        builder.UseSqlServer(
            connectionString,
            options => options.MigrationsAssembly(typeof(SqlServerDataAssemblyMarker).Assembly.GetName().Name));

        return new {PascalModuleName}DbContext(builder.Options);
    }
}
