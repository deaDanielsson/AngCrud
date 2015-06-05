using System.Web;
using System.Web.Mvc;

namespace NTiere_Angularjs_codefirst_Simply.MVC.UI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}