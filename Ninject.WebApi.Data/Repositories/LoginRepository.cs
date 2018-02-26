using Ninject.WebApi.Core.RepositoryInterfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

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

        public bool ValidateUser(string name, string password)
        {
            using (var dbContext = new MPEntities())
            {
                return dbContext.UserDetails.Any(x => x.Name.ToLower().Equals(name.ToLower())
                                                && x.Password.ToLower().Equals(password.ToLower()));
            }
        }
    }
}
