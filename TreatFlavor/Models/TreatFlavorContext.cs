using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TreatFlavor.Models
{
    public class TreatFlavorContext : IdentityDbContext<ApplicationUser>
    {
      public DbSet<Flavor> Flavors { get; set; }
      public DbSet<Item> Treats { get; set; }
      public DbSet<FlavorItem> FlavorItem { get; set; }

      public TreatFlavorContext(DbContextOptions options) : base(options) { }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
        optionsBuilder.UseLazyLoadingProxies();
      }
  }
}