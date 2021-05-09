using Microsoft.EntityFrameworkCore;

namespace MinimalReproducibleExample
{
    internal sealed class FooContext : DbContext
    {
        public static FooContext CreateContext(string connectionString)
        {
            var options = new DbContextOptionsBuilder<FooContext>()
                .EnableSensitiveDataLogging(true)
                .UseSqlServer(connectionString, opts =>
                {
                    opts.UseRelationalNulls(false);
                }).Options;
            return new FooContext(options);
        }

        private FooContext(DbContextOptions<FooContext> options) : base(options)
        {
        }

        public DbSet<Bar> Bars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var barEntity = modelBuilder.Entity<Bar>();
            barEntity.HasKey(x => x.Id);
            barEntity.OwnsOne(
                x => x.BarUniqueId,
                x =>
                {
                    x.Property(p => p.BarId)
                        .ValueGeneratedNever()
                        .HasColumnName("BarId");
                }
            );
        }
    }
}
