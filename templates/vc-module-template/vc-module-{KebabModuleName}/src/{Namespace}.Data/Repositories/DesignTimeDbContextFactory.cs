using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace {Namespace}.Data.Repositories;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<{ModuleName}DbContext>
{
    public {ModuleName}DbContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<{ModuleName}DbContext>();
        var connectionString = args.Length != 0 ? args[0] : "Server=(local);User=virto;Password=virto;Database=VirtoCommerce3;";

        builder.UseSqlServer(
            connectionString,
            options => options.MigrationsAssembly(typeof(SqlServerDataAssemblyMarker).Assembly.GetName().Name));

        return new {ModuleName}DbContext(builder.Options);
    }
}
