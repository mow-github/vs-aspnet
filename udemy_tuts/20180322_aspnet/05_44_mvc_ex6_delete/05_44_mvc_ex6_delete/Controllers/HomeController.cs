using _05_44_mvc_ex6_delete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Web;
using System.Web.Mvc;

namespace _05_44_mvc_ex6_delete.Controllers
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

    public ActionResult ViewCustomer(string Id)
    {
      Customer customer = customers.FirstOrDefault(c => c.Id == Id);
      if (customer == null)
      {
        return HttpNotFound();
      }
      else
      {
        return View(customer);
      }
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

      return RedirectToAction("CustomerList");
    }

    [HttpGet]
    public ActionResult EditCustomer(string Id)
    {
      Customer customer = customers.FirstOrDefault(c => c.Id == Id);
      if (customer == null)
      {
        return HttpNotFound();
      }
      else
      {
        return View(customer);
      }
    }

    [HttpPost]
    public ActionResult EditCustomer(Customer customer, string Id)
    {
      Customer customerToEdit = customers.FirstOrDefault(c => c.Id == Id);
      if (customer == null)
      {
        return HttpNotFound();
      }
      else
      {
        customerToEdit.Name = customer.Name;
        customerToEdit.Telephone = customer.Telephone;
        SaveCache();
        return RedirectToAction("CustomerList");
      }
    }

    [HttpPost]
    public ActionResult DeleteCustomer(string Id)
    {
      Customer customer = customers.FirstOrDefault(c => c.Id == Id);
      if (customer == null)
      {
        return HttpNotFound();
      }
      else
      {
        return View(customer);
      }
    }

    [ActionName("DeleteCustomer")]
    public ActionResult ConfirmDeleteCustomer(string Id)
    {
      Customer customer = customers.FirstOrDefault(c => c.Id == Id);
      if (customer == null)
      {
        return HttpNotFound();
      }
      else
      {
        customers.Remove(customer);
        return RedirectToAction("CustomerList");
      }
    }

    public ActionResult CustomerList()
    {

      //List<Customer> customers = new List<Customer>();
      //customers.Add(new Customer() { Name = "Fred", Telephone = "21333" });
      //customers.Add(new Customer() { Name = "Moa", Telephone = "5634" });

      return View(customers);
    }

  }
}