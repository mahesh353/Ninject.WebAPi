using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Web.Http.Results;

namespace Ninject.WebApi.Filters
{
    public class AuthenticationFilter : ActionFilterAttribute
    {
        int _roleId;
        public AuthenticationFilter(int role)
        {
            this._roleId = role;
        }
        public override void OnActionExecuting(HttpActionContext actionContext)

        {
            if (_roleId == 1)
            {
                base.OnActionExecuting(actionContext);
            }
            else {
                actionContext.Response = new HttpResponseMessage(statusCode :System.Net.HttpStatusCode.Unauthorized);
            }
           
        }
    }
}