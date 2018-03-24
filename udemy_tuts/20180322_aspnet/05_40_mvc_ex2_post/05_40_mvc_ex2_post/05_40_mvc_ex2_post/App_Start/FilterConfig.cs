using System.Web;
using System.Web.Mvc;

namespace _05_40_mvc_ex2_post
{
  public class FilterConfig
  {
    public static void RegisterGlobalFilters(GlobalFilterCollection filters)
    {
      filters.Add(new HandleErrorAttribute());
    }
  }
}
