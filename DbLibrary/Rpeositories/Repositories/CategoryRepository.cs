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

    public class CategoryRepository : GenericRepository<Category, int>, ICategoryRepository
    {
        public Category ?GetByName(string name) =>
            context.Categories.FirstOrDefault(c=>c.Name == name);
        public IEnumerable<Category> GetCategoryWithBooks() =>
            context.Categories.Include(c => c.Books).ToList();
    }
}
