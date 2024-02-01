using ConsoleApp10.Concrets;
using ConsoleApp10.Rpeositories.BaseRepositories;
using ConsoleApp10.Rpeositories.GenericRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLibrary.Rpeositories.BaseRepositories
{
    internal class TeacherRepository : GenericRepository<Teacher, int>, ITeacherRepository
    {
        public Teacher ?GetByName(string name) =>
            context.Teachers.FirstOrDefault(t=>t.FirstName==name);

        public IEnumerable<Teacher> GetFullData() =>
            context.Teachers.Include(t => t.IdDepNavigation).ToList();
    }
}
