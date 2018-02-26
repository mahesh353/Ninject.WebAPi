using Ninject.WebApi.Core.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ninject.WebApi.Filters
{
    public class AuthTokenVerify
    {
        private ILoginRepository _loginRepository;
        public AuthTokenVerify(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        public dynamic VerifyAuthToken(string authHeader)
        {
            bool isValid = false;

            if (authHeader != null)
            {
                string authToken = authHeader.Substring("Basic ".Length).Trim();
                if (authToken != null)
                {
                    return _loginRepository.ValidateToken(authHeader);
                }
            }
            return isValid;
        }
    }
}