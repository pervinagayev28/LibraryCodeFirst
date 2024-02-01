using ConsoleApp10.Concrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Rpeositories.BaseRepositories
{
    public interface IBookRepository 
    {
        Book GetBookByName(string name);
        IEnumerable<Book> GetBooksWithStudents();

    }
}
