using System.Web;
using System.Web.Mvc;

namespace ASSIGNMENT01_BRYANHUGHES
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
