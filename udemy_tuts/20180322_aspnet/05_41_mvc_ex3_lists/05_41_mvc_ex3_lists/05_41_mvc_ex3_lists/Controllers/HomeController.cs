using _05_41_mvc_ex3_lists.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _05_41_mvc_ex3_lists.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult About()
    {
      ViewBag.Message = "Your application description page.";

      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Your contact page.";

      return View();
    }

    public ActionResult ViewCustomer(Customer cObj)
    {
      Customer customer = new Customer();

      customer.Id = Guid.NewGuid().ToString();
      customer.Name = "Fred";
      customer.Telephone = "123456";

      if (cObj != null)
      {
        customer.Name = cObj.Name;
        customer.Telephone = cObj.Telephone;
      }

      return View(customer);
    }

    [HttpGet]
    public ActionResult AddCustomer()
    {
      return View();
    }

    public ActionResult CustomerList()
    {

      List<Customer> customers = new List<Customer>();
      customers.Add(new Customer() { Name = "Fred", Telephone = "21333" });
      customers.Add(new Customer() { Name = "Moa", Telephone = "5634" });

      return View(customers);
    }

  }
}