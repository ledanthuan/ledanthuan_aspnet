using System.Web;
using System.Web.Mvc;

namespace LeDanThuan_2122110052
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
