﻿using System.Web;
using System.Web.Mvc;

namespace learning_full_stack_developer_dotnet_framework
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
