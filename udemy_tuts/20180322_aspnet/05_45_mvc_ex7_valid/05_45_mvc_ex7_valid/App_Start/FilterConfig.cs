﻿using System.Web;
using System.Web.Mvc;

namespace _05_45_mvc_ex7_valid
{
  public class FilterConfig
  {
    public static void RegisterGlobalFilters(GlobalFilterCollection filters)
    {
      filters.Add(new HandleErrorAttribute());
    }
  }
}
