using System.Reflection;
using Microsoft.EntityFrameworkCore;
//using VirtoCommerce.Platform.Data.Extensions;
using VirtoCommerce.Platform.Data.Infrastructure;

namespace {Namespace}.Data.Repositories;

public class {PascalModuleName}DbContext : DbContextBase
{
    public {PascalModuleName}DbContext(DbContextOptions<{PascalModuleName}DbContext> options)
        : base(options)
    {
    }

    protected {PascalModuleName}DbContext(DbContextOptions options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //modelBuilder.Entity<BazQuxEntity>().ToAuditableEntityTable("BazQux");

        switch (Database.ProviderName)
        {
            case "Pomelo.EntityFrameworkCore.MySql":
                modelBuilder.ApplyConfigurationsFromAssembly(Assembly.Load("{Namespace}.Data.MySql"));
                break;
            case "Npgsql.EntityFrameworkCore.PostgreSQL":
                modelBuilder.ApplyConfigurationsFromAssembly(Assembly.Load("{Namespace}.Data.PostgreSql"));
                break;
            case "Microsoft.EntityFrameworkCore.SqlServer":
                modelBuilder.ApplyConfigurationsFromAssembly(Assembly.Load("{Namespace}.Data.SqlServer"));
                break;
        }
    }
}
