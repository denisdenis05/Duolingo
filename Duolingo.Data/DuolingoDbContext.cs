//using Duolingo.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Duolingo.Data;

public class DuolingoDbContext : DbContext
{
    public DuolingoDbContext(DbContextOptions<DuolingoDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        /*modelBuilder.ApplyConfiguration(new InterviewConfiguration());*/
        base.OnModelCreating(modelBuilder);
    }
}
