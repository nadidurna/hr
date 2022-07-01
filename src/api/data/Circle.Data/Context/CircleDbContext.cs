using Circle.Entities.Main;
using Circle.Entities.Profile;

namespace Circle.Data.Context;

public class CircleDbContext : DbContext
{
    public CircleDbContext(DbContextOptions options) : base(options)
    {
    }

    //public DbSet<Entity> Entities {get; set;}
    public DbSet<Lookup> Lookups { get; set; }
    public DbSet<LookupType> LookupTypes { get; set; }
    public DbSet<CompanyManager> CompanyManagers { get; set; }
    public DbSet<Employee> Employees { get; set; }
}