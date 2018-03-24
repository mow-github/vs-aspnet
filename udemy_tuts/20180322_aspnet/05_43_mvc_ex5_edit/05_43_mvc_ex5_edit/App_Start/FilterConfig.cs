using System.Web;
using System.Web.Mvc;

namespace _05_43_mvc_ex5_edit
{
  public class FilterConfig
  {
    public static void RegisterGlobalFilters(GlobalFilterCollection filters)
    {
      filters.Add(new HandleErrorAttribute());
    }
  }
}
