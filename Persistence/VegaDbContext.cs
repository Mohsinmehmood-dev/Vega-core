using Microsoft.EntityFrameworkCore;
using Vega.net;

namespace Vega.net;

public class VegaDbContext : DbContext
{
    public VegaDbContext(DbContextOptions<VegaDbContext> options) : base(options)
    {
        
    }
 public DbSet<Make> Makes { get; set; }

public DbSet<Vega.net.Model> Models { get; set; } = default!;

public DbSet<Feature> Features { get; set; }
}
