using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Web;
using System.Web.Mvc;
using testaspnetbasic.Models;

namespace testaspnetbasic.Controllers
{
  public class HomeController : Controller
  {

    ObjectCache cache = MemoryCache.Default;
    List<Customer> customers;

    public HomeController()
    {
      customers = cache["customers"] as List<Customer>;
      if (customers == null)
      {
        customers = new List<Customer>();
      }
    }

    public void SaveCache()
    {
      cache["customers"] = customers;
    }

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

      if (cObj != null) {
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

    [HttpPost]
    public ActionResult AddCustomer(Customer customer)
    {
      customer.Id = Guid.NewGuid().ToString();
      customers.Add(customer);
      SaveCache();

      return RedirectToAction("ListCustomer");
      // return View();
    }


    public ActionResult ListCustomer()
    {

      // Inactive atm - we use the global customers object in conjunc. with cache..

      //List < Customer > customers = new List<Customer>();
      //customers.Add(new Customer() { Name = "Fred", Telephone = "21333" });
      //customers.Add(new Customer() { Name = "Moa", Telephone = "5634" });

      return View(customers);
    }




  }
}