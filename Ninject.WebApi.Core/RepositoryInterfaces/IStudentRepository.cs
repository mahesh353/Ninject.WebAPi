using Ninject.WebApi.Core.Models;
using System.Collections.Generic;

namespace Ninject.WebApi.Core.RepositoryInterfaces
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetStudents();
    }
}
