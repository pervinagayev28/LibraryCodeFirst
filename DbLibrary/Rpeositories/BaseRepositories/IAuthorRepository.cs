using ConsoleApp10.Concrets;
using ConsoleApp10.Rpeositories.GenericRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Rpeositories.BaseRepositories
{
    public interface IAuthorRepository 
    {
        IEnumerable<Author> GetAllAuthorsWithBooks();
        IEnumerable<Author> GetAllAuthosrWithBookWhereHasOne();

    }
}
