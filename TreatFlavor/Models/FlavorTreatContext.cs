using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TreatFlavor.Models
{
    public class FlavorTreatContext : IdentityDbContext<ApplicationUser>
    {
      public DbSet<Flavor> Flavors { get; set; }
      public DbSet<Treat> Treats { get; set; }
      public DbSet<FlavorTreat> FlavorTreat { get; set; }

      public FlavorTreatContext(DbContextOptions options) : base(options) { }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
        optionsBuilder.UseLazyLoadingProxies();
      }
  }
}