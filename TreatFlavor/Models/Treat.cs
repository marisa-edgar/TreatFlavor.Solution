using System.Collections.Generic;

namespace TreatFlavor.Models
{
  public class Treat
  {
    public Treat()
    {
      this.JoinEntities = new HashSet<FlavorTreat>();
    }

    public int TreatId { get; set; }

    public int Name { get; set; }
    public string Description { get; set; }

    public string Price { get; set; }

    public string Allergens { get; set; }

    public virtual ApplicationUser User { get; set; }

    public virtual ICollection<FlavorTreat> JoinEntities { get;}
  }
}