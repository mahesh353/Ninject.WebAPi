using Ninject.WebApi.Core.Models;
using Ninject.WebApi.Core.RepositoryInterfaces;
using System;
using System.Linq;

namespace Ninject.WebApi.Data.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        public bool ValidateToken(string authToken)
        {
            using (var dbContext = new MPEntities())
            {
                return dbContext.UserDetails.Any(x => x.Token == authToken);
            }
        }

        public LoginStatus ValidateUser(string name, string password)
        {


            var loginStatus = default(LoginStatus);
            using (var dbContext = new MPEntities())
            {
                loginStatus = new LoginStatus();
                var user = dbContext.UserDetails.Where(x => x.Name.ToLower().Equals(name.ToLower())
                                               && x.Password.ToLower().Equals(password.ToLower())).FirstOrDefault();
                if (user != null)
                {
                    user.Token = Guid.NewGuid().ToString();
                    dbContext.SaveChanges();
                    loginStatus.IsSuccess = true;
                    loginStatus.AuthToken = user.Token;
                }
            }
            return loginStatus;
        }
    }
}
