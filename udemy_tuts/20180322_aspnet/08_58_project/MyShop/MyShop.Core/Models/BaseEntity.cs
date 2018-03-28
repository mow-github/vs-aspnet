using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
  // 1. abstract - can not create a object of this class solo.. it must be inherited
  // 2. used in .DataAccess.InMemory S. etc.. <T> generics class..  --> we use this BaseEntity class.. so the other class knows that all <T> classes must have Id and datatime
  public abstract class BaseEntity
  {
    public string Id { get; set; }
    public DateTimeOffset CreatedAt { get; set; }

    public BaseEntity()
    {
      this.Id = Guid.NewGuid().ToString();
      this.CreatedAt = DateTime.Now;
    }

  }
}
