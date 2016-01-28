using System.Web;
using System.Web.Mvc;

namespace Evaluación_Giovanni_Crescencio_Ahuactzi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
