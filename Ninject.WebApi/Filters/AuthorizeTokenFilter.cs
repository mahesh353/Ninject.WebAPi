using Ninject.WebApi.Core.RepositoryInterfaces;
using Ninject.WebApi.Data.Repositories;
using System.Net;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Ninject.WebApi.Filters
{
    public class AuthorizeTokenFilter : AuthorizationFilterAttribute
    {

        private const string AUTHORIZATION = "Authorization";
        AuthTokenVerify authTokenVerify = null;

        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.Request.Headers.Authorization == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
            }
            else
            {
                var authHeader = actionContext.Request.Headers.Authorization.Parameter;
                //var _loginRepository = (ILoginRepository)actionContext.RequestContext.GetService(typeof(ILoginRepository));
                var _loginRepository = new LoginRepository();//(ILoginRepository)System.Web.Mvc.DependencyResolver.Current.GetService(typeof(ILoginRepository));

                authTokenVerify = new AuthTokenVerify(_loginRepository);
                if (!authTokenVerify.VerifyAuthToken(authHeader))//Verify the token and return bool)
                {
                    //if not valid
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized, "Invalid token");
                }

            }

            base.OnAuthorization(actionContext);
        }
    }
}