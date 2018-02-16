using System;
using System.Collections.Generic;
using Ninject.WebApi.Core.Models;
using Ninject.WebApi.Core.RepositoryInterfaces;
using System.Linq;

namespace Ninject.WebApi.Data.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public List<Ninject.WebApi.Core.Models.Student> stundentList = new List<Ninject.WebApi.Core.Models.Student>();
        

        public StudentRepository()
        {

            

        }

        List<Core.Models.Student> IStudentRepository.GetStudents()
        {
            using (MPEntities mp = new MPEntities())
            {
                var students = mp.Students.ToList();
                foreach (var studentItem in students)
                {
                    Core.Models.Student student = new Core.Models.Student();
                    student.Id = studentItem.Id;
                    student.Name = studentItem.Name;
                    student.Address = studentItem.Address;
                    stundentList.Add(student);
                }
            }
            return stundentList;
        }
    }
}
