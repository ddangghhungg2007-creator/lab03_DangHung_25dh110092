using System.Web;
using System.Web.Mvc;

namespace lab03_DangHung_25dh110092
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
