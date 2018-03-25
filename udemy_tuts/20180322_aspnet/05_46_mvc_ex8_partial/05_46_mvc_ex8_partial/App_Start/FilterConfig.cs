using System.Web;
using System.Web.Mvc;

namespace _05_46_mvc_ex8_partial
{
  public class FilterConfig
  {
    public static void RegisterGlobalFilters(GlobalFilterCollection filters)
    {
      filters.Add(new HandleErrorAttribute());
    }
  }
}
