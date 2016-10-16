﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HarperSoftware.Web.Filters
{
    public class UnderConstructionAttribute : ActionFilterAttribute
    {
        private static AppSettingsReader _reader;

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            _reader = new AppSettingsReader();
            if ((bool)_reader.GetValue("UnderConstruction", typeof(bool)))
                filterContext.HttpContext.Response.Redirect("/UnderConstruction.html");
        }


    }
}