using Microsoft.EntityFrameworkCore;

namespace {Namespace}.Data.SqlServer;

public static class DbContextOptionsBuilderExtensions
{
    /// <summary>
    /// Configures the context to use SQL Server.
    /// </summary>
    public static DbContextOptionsBuilder UseSqlServerDatabase(this DbContextOptionsBuilder builder, string connectionString) =>
        builder.UseSqlServer(
            connectionString,
            options => options.MigrationsAssembly(typeof(DesignTimeDbContextFactory).Assembly.GetName().Name));
}
