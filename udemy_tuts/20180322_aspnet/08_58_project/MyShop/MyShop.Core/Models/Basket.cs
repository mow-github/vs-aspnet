using System.Collections.Generic;

namespace MyShop.Core.Models
{
  public class Basket : BaseEntity
  {
    // virtual keyword: good for MS Entity Framework.. so basket and basketitems request works together
    // also knows as: lazy loading ( if you get the basket.. get the linked basketitems as well.. )

    public virtual ICollection<BasketItem> BasketItems { get; set; }

    public Basket()
    {
      this.BasketItems = new List<BasketItem>();
    }

  }
}
