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
    internal class T_CardRepository : GenericRepository<TCard, int>, IT_CardRepository
    {
        public TCard ?GetByName(int Id) =>
            context.TCards.FirstOrDefault(tc=>tc.Id==Id);

        public IEnumerable<TCard> GetFullData() =>
            context.TCards.Include(tc => tc.IdBookNavigation).ToList();
    }
}
