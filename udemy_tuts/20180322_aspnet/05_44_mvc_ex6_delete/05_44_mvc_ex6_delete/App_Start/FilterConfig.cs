using System.Web;
using System.Web.Mvc;

namespace _05_44_mvc_ex6_delete
{
  public class FilterConfig
  {
    public static void RegisterGlobalFilters(GlobalFilterCollection filters)
    {
      filters.Add(new HandleErrorAttribute());
    }
  }
}
