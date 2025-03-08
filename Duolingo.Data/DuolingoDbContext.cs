//using Duolingo.Data.Configurations;

using Duolingo.Data.Configurations;
using Duolingo.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Duolingo.Data;

public class DuolingoDbContext : DbContext
{
    public DuolingoDbContext(DbContextOptions<DuolingoDbContext> options) : base(options)
    {
    }

    public DbSet<Test> Tests { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new TestConfiguration());
        base.OnModelCreating(modelBuilder);
    }
}
