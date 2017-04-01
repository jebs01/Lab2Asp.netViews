using System.Web;
using System.Web.Mvc;

namespace Lab2Asp.NetMVCViews
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
