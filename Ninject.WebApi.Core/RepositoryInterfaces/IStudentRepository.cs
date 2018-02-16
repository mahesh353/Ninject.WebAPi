using Ninject.WebApi.Core.Models;
using System.Collections.Generic;

namespace Ninject.WebApi.Core.RepositoryInterfaces
{
    public interface IStudentRepository
    {
        List<Student> GetStudents();
    }
}
