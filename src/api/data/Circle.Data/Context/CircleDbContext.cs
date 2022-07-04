using Circle.Entities.Associate;
using Circle.Entities.Foundation;
using Circle.Entities.Main;
using Circle.Entities.Profile;
using Circle.Entities.Usage;

namespace Circle.Data.Context;

public class CircleDbContext : DbContext
{
    public CircleDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Lookup> Lookups { get; set; }
    public DbSet<LookupType> LookupTypes { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<CompanyUser> CompanyUsers { get; set; }
    public DbSet<Permit> Permits { get; set; }
    public DbSet<Debit> Debits { get; set; }
}