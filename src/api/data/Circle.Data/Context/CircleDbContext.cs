namespace Circle.Data.Context;

public class CircleDbContext : DbContext
{
    public CircleDbContext(DbContextOptions options) : base(options)
    {
    }

    //public DbSet<Entity> Entities {get; set;}
}