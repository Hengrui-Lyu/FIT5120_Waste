﻿using System.Web;
using System.Web.Mvc;

namespace FIT5120_Waste
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
