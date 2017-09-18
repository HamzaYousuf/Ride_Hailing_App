using System.Web;
using System.Web.Mvc;

namespace Ride_Hailing_AdminPanel
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
