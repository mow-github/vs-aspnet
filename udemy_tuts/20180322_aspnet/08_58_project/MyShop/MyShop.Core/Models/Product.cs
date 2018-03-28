using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
  public class Product : BaseEntity
  {

    // Alt + Enter: add reference.. DataAnnotations (regexp decorators)
    [StringLength(20)]
    [DisplayName("Product Name")]
    public string Name { get; set; }
    public string Descprition { get; set; }

    // range 0 - 1000 and remove price format, etc: 45,00
    [Range(0, 1000)]
    [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
    public decimal Price { get; set; }
    public string Category { get; set; }
    public string Image { get; set; }

  }
}
