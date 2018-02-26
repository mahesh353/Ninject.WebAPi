using Ninject.WebApi.Core.Models;
using System.Threading.Tasks;

namespace Ninject.WebApi.Core.RepositoryInterfaces
{
    public interface ILoginRepository
    {
        LoginStatus ValidateUser(string name, string password);
        bool ValidateToken(string authToken);

    }
}
