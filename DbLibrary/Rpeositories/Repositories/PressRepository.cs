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
    internal class PressRepository : GenericRepository<Press, int>, IPressRepository
    {
        public Press ?GetByName(string name) =>
            context.Presses.FirstOrDefault(p=>p.Name==name);

        public IEnumerable<Press> GetFullData() =>
            context.Presses.Include(p=>p.Books).ToList();
    }
}
