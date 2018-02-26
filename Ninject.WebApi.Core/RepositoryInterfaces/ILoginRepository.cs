using Ninject.WebApi.Core.Models;

namespace Ninject.WebApi.Core.RepositoryInterfaces
{
    public interface ILoginRepository
    {
        LoginStatus ValidateUser(string name, string password);
        bool ValidateToken(string authToken);

    }
}
