using System;
using System.Web.Mvc;

namespace SmartAdminMvc
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class CustomAuthorize : AuthorizeAttribute
    {
        public string RedirectUrl = "~/Misc/Unauthorized";

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            base.HandleUnauthorizedRequest(filterContext);

            if (filterContext.RequestContext.HttpContext.User.Identity.IsAuthenticated)
            {
                filterContext.Result = new RedirectResult(RedirectUrl);
            }
        }
    }
}