using System.Web;
using System.Web.Mvc;

namespace ZQNet.Presentation.Web.ZQPhoenix
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
