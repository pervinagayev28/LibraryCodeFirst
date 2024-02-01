using ConsoleApp10.Concrets;
using ConsoleApp10.Rpeositories.BaseRepositories;
using ConsoleApp10.Rpeositories.GenericRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Rpeositories.SimpleRepositories
{
    public class AuthorRepository : GenericRepository<Author, int>, IAuthorRepository
    {

        public IEnumerable<Author> GetAllAuthorsWithBooks() =>
                    context.Authors.Include(a => a.Books).ToList();

        public IEnumerable<Author> GetAllAuthosrWithBookWhereHasOne() =>
                    context.Authors.Where(a=>a.Books.Count==1).Include(a => a.Books).ToList();

      
    }
}
