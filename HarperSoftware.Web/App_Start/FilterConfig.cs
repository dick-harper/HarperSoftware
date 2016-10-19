using System.Web;
using System.Web.Mvc;
using HarperSoftware.Web.Filters;

namespace HarperSoftware.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new WebsiteOfflineAttribute());
            filters.Add(new UnderConstructionAttribute());
        }
    }
}
