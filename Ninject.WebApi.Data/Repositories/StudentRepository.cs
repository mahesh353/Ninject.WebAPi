using System;
using System.Collections.Generic;
using Ninject.WebApi.Core.Models;
using Ninject.WebApi.Core.RepositoryInterfaces;
using System.Linq;

namespace Ninject.WebApi.Data.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public List<Student> stundentList = new List<Student>();
        MPEntities NinjectEntities = new MPEntities();

        public StudentRepository()
        {

//            stundents.Add(new Student { Id = 10, Name = "Mahesh" });
        }
        public IEnumerable<Student> GetStudents()
        {
            var students = NinjectEntities.STUDENTs.ToList();
            foreach (var item in students)
            {
                stundentList.Add(new Student { Id = item.ID, Name = item.NAME });
            }
            return stundentList;
        }
    }
}
