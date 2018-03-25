using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace _05_45_mvc_ex7_valid.Models
{
  public class Customer
  {
    public string Id { get; set; }

    [Required]
    [StringLength(10, ErrorMessage = "Your string is too long!")]
    [DisplayName("Enter your name")]
    public string Name { get; set; }
    public string Telephone { get; set; }
  }
}