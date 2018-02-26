using System.Threading.Tasks;

namespace Ninject.WebApi.Core.RepositoryInterfaces
{
    public interface ILoginRepository
    {
        bool ValidateUser(string name, string password);
        bool ValidateToken(string authToken);

    }
}
