using ConsoleApp10.Concrets;
using ConsoleApp10.Rpeositories.BaseRepositories;
using ConsoleApp10.Rpeositories.GenericRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Rpeositories.SimpleRepositories
{
    public class S_CardRepository : GenericRepository<SCard, int>, IS_CardRepository
    {
        public SCard ?GetByName(int Id) =>
            context.SCards.FirstOrDefault(sc=>sc.Id==Id);

        IEnumerable<SCard> IS_CardRepository.GetFullData() => 
                context.SCards.Include(sc => sc.IdStudentNavigation).Include(sc => sc.IdBookNavigation).ToList();




    }
}
