using ConsoleApp10.Concrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLibrary.Rpeositories.BaseRepositories
{
    public interface IPressRepository
    {
        IEnumerable<Press> GetFullData();
        Press GetByName(string name);
    }
}
