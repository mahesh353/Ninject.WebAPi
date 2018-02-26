using Ninject.WebApi.Core.RepositoryInterfaces;
using Ninject.WebApi.Filters;
using Ninject.WebApi.Models;
using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace Ninject.WebApi.Controllers
{
   
    public class LoginController : ApiController
    {
        private ILoginRepository _loginRepository;

        public LoginController(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        
        [HttpGet]
        [Route("login/{name}/{password}")]
      
        public async Task<IHttpActionResult> ValidateUser(string name, string password)
        {

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password))
            {
                return BadRequest();
            }

            var status = _loginRepository.ValidateUser(name, password);

            if (status != null)
            {
                return Ok(status);
            }
            else
            {
                return Unauthorized();
            }


        }

    }
}
