﻿using System.Web;
using System.Web.Mvc;

namespace _05_41_mvc_ex3_lists
{
  public class FilterConfig
  {
    public static void RegisterGlobalFilters(GlobalFilterCollection filters)
    {
      filters.Add(new HandleErrorAttribute());
    }
  }
}
