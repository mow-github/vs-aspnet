using _05_40_mvc_ex2_post.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_ex1.Controllers
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

  }
}