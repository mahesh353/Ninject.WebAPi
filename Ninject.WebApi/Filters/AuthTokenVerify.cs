using Ninject.WebApi.Core.RepositoryInterfaces;

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

                return _loginRepository.ValidateToken(authHeader);

            }
            return isValid;
        }
    }
}