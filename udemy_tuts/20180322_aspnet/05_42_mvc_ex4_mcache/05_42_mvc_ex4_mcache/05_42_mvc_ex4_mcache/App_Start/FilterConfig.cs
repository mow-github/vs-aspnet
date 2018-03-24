using System.Web;
using System.Web.Mvc;

namespace _05_42_mvc_ex4_mcache
{
  public class FilterConfig
  {
    public static void RegisterGlobalFilters(GlobalFilterCollection filters)
    {
      filters.Add(new HandleErrorAttribute());
    }
  }
}
