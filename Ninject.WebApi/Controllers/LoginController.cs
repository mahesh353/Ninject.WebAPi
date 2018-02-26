using Ninject.WebApi.Core.RepositoryInterfaces;
using Ninject.WebApi.Models;
using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace Ninject.WebApi.Controllers
{
    [AllowAnonymous]
    public class LoginController : ApiController
    {
        private ILoginRepository _loginRepository;

        public LoginController(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }


        [Route("login/{name}/{password}")]
        public async Task<IHttpActionResult> ValidateUser(string name, string password)
        {
            LoginStatus loginStatus = default(LoginStatus);
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password))
            {
                return BadRequest();
            }

            var status = _loginRepository.ValidateUser(name, password);

            if (status)
            {
                loginStatus = new LoginStatus();
                loginStatus.IsSuccess = true;
                loginStatus.AuthToken = Guid.NewGuid().ToString();
            }

            return Ok(loginStatus);
        }

    }
}
