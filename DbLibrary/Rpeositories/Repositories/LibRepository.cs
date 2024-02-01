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
    internal class LibRepository : GenericRepository<Lib, int>, ILibRepository
    {
        public Lib ?GetByName(string name) =>
            context.Libs.FirstOrDefault(l=>l.FirstName==name);

        public IEnumerable<Lib> GetFullData() =>
            context.Libs.Include(l => l.SCards).ToList();
    }
}
