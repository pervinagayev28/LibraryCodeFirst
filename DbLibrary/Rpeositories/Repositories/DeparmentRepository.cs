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
    internal class DeparmentRepository : GenericRepository<Department, int>, IDeparmentRepository
    {
        public Department ?GetByName(string name) =>
            context.Departments.FirstOrDefault(d=>d.Name==name);

        public IEnumerable<Department> GetFullData() =>
            context.Departments.Include(d => d.Teachers).ToList();
    }
}
