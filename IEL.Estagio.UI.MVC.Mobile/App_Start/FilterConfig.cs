using System.Web;
using System.Web.Mvc;

namespace IEL.Estagio.UI.MVC.Mobile
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
