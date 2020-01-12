using System.Web;
using System.Web.Mvc;

namespace File_Serialization_and_Deserialization_Tool
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
