using ConsoleApp10.Concrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLibrary.Rpeositories.BaseRepositories
{
    public interface ITeacherRepository
    {
        IEnumerable<Teacher> GetFullData();
        Teacher GetByName(string name);
    }
}
