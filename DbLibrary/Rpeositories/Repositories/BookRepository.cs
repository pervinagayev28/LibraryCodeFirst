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
    public class BookRepository : GenericRepository<Book, int>, IBookRepository
    {
        public Book ?GetBookByName(string name)=>
            context.Books.FirstOrDefault(b=>b.Name==name);

        public IEnumerable<Book> GetBooksWithStudents() =>
            context.Books.Include(b => b.SCards)!.ThenInclude(sc => sc.IdStudentNavigation).ToList();
    }
}
