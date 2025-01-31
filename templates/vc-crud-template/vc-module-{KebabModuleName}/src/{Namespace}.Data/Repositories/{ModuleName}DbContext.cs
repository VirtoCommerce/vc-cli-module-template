using System.Reflection;
using Microsoft.EntityFrameworkCore;
using VirtoCommerce.Platform.Data.Infrastructure;
using {Namespace}.Data.Models;

namespace {Namespace}.Data.Repositories;

public class {ModuleName}DbContext : DbContextBase
{
    public {ModuleName}DbContext(DbContextOptions<{ModuleName}DbContext> options)
        : base(options)
    {
    }

    protected {ModuleName}DbContext(DbContextOptions options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<{EntityName}Entity>().ToTable("{EntityName}").HasKey(x => x.Id);
        modelBuilder.Entity<{EntityName}Entity>().Property(x => x.Id).HasMaxLength(IdLength).ValueGeneratedOnAdd();

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
