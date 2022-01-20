using EntityFrameworkCore.Triggers;
using Microsoft.EntityFrameworkCore;

namespace {Namespace}.Data.Repositories
{
    public class {ModuleName}DbContext : DbContextWithTriggers
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
            //        modelBuilder.Entity<{ModuleName}Entity>().ToTable("MyModule").HasKey(x => x.Id);
            //        modelBuilder.Entity<{ModuleName}Entity>().Property(x => x.Id).HasMaxLength(128);
            //        base.OnModelCreating(modelBuilder);
        }
    }
}

