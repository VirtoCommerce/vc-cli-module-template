using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using {Namespace}.Data.Repositories;

namespace {Namespace}.Data.PostgreSql;

public class PostgreSqlDbContextFactory : IDesignTimeDbContextFactory<{ModuleName}DbContext>
{
    public {ModuleName}DbContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<{ModuleName}DbContext>();
        var connectionString = args.Any() ? args[0] : "User ID = postgres; Password = password; Host = localhost; Port = 5432; Database = virtocommerce3;";

        builder.UseNpgsql(
            connectionString,
            db => db.MigrationsAssembly(typeof(PostgreSqlDbContextFactory).Assembly.GetName().Name));

        return new {ModuleName}DbContext(builder.Options);
    }
}
