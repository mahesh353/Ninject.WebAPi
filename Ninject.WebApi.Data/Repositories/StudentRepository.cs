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
        

        public StudentRepository()
        {

            stundentList.Add(new Student { Id = 10, Name = "Mahesh" });
            stundentList.Add(new Student { Id = 11, Name = "Pankaj" });
            stundentList.Add(new Student { Id = 12, Name = "Shubham" });

        }

        public IEnumerable<Student> GetStudents()
        {
            //using (MPEntities NinjectEntities = new MPEntities())
            //{
            //    var employees = NinjectEntities.EMPLOYEEs.ToList();
            //    foreach (var item in employees)
            //    {
            //        stundentList.Add(new Student { Id = item.ID, Name = item.NAME });
            //    }
            //}
            return stundentList;
        }
    }
}
