using ConsoleApp10.Concrets;
using ConsoleApp10.Rpeositories.BaseRepositories;
using ConsoleApp10.Rpeositories.GenericRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp10.Rpeositories.SimpleRepositories
{

    public class Studentrepository : GenericRepository<Student, int>, IStudentRepository
    {
        public Student? GetStudentByName(string name) =>
            context.Students.FirstOrDefault(s => s.FirstName == name);

        public Student? GetStudentBySurname(string surname) =>
                        context.Students.FirstOrDefault(s => s.LastName == surname);

    }
}
