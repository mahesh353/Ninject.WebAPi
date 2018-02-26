using Ninject.WebApi.Core.Models;
using Ninject.WebApi.Core.RepositoryInterfaces;
using Ninject.WebApi.Filters;
using System.Collections.Generic;
using System.Web.Http;

namespace Ninject.WebApi.Controllers
{
    [AuthorizeTokenFilter]
    public class StudentController : ApiController
    {
        private IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public IEnumerable<Student> Get()
        {
            
            return _studentRepository.GetStudents();
        }


    }
}
