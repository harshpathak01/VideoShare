using Microsoft.AspNetCore.Mvc.Rendering;

namespace VideoShare.Utility
{
    public static class SD
    {
        public static string IsActive(this IHtmlHelper html, string controller, string action, string cssClass = "active")
        {
            var routeData = html.ViewContext.RouteData;
            var currentController = routeData.Values["controller"].ToString();
            var currentAction = routeData.Values["action"].ToString();
            return (currentController == controller && currentAction == action) ? cssClass : string.Empty;
        }
    }
}
