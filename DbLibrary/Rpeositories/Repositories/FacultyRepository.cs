using ConsoleApp10.Concrets;
using ConsoleApp10.Rpeositories.GenericRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLibrary.Rpeositories.BaseRepositories
{
    public class FacultyRepository : GenericRepository<Faculty, int>, IFacultyRepository
    {

        IEnumerable<Faculty> IFacultyRepository.GetFullData() =>
            context.Faculties.Include(f => f.Groups).ToList();

        Faculty? IFacultyRepository.GetByName(string name) =>
            context.Faculties.FirstOrDefault(f=>f.Name==name);
    }
}
