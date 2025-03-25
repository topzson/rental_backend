using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EtaxService.Installers
{
    public class HeadersAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var request = context.HttpContext.Request;
            var path = request.Path.Value;

            if (path != null && (
                path.StartsWith("/swagger") ||
                path.StartsWith("/health")))
            {
                base.OnActionExecuting(context);
                return;
            }

            if (request.Method != "GET" &&
                (!request.Headers.ContainsKey("Content-Type") ||
                 !request.Headers["Content-Type"].ToString().Contains("application/json")))
            {
                context.Result = new ContentResult
                {
                    StatusCode = StatusCodes.Status415UnsupportedMediaType,
                    Content = "Content-Type must be application/json"
                };
                return;
            }

            base.OnActionExecuting(context);
        }
    }
}
