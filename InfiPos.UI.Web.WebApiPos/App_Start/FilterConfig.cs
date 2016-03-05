using System.Web;
using System.Web.Mvc;

namespace InfiPos.UI.Web.WebApiPos
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
