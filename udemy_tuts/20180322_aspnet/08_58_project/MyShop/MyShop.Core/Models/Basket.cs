using System.Collections.Generic;

namespace MyShop.Core.Models
{
  public class Basket : BaseEntity
  {
    // virtual keyword: good for MS Entity Framework.. so basket and basketitems request works together

    public virtual ICollection<BasketItem> BasketItems { get; set; }

    public Basket()
    {
      this.BasketItems = new List<BasketItem>();
    }

  }
}
