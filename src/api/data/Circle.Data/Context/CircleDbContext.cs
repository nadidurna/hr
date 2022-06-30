using Circle.Entities.Main;

namespace Circle.Data.Context;

public class CircleDbContext : DbContext
{
    public CircleDbContext(DbContextOptions options) : base(options)
    {
    }

    //public DbSet<Entity> Entities {get; set;}
    public DbSet<Lookup> Lookups { get; set; }
    public DbSet<LookupType> LookupTypes { get; set; }
}