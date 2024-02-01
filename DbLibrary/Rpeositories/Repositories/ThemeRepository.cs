using ConsoleApp10.Concrets;
using ConsoleApp10.Rpeositories.BaseRepositories;
using ConsoleApp10.Rpeositories.GenericRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLibrary.Rpeositories.BaseRepositories
{
    internal class ThemeRepository : GenericRepository<Theme, int>, IThemeRepository
    {
        public Theme ?GetByName(string name) =>
            context.Themes.FirstOrDefault(t=>t.Name==name);

        public IEnumerable<Theme> GetFullData() =>
            context.Themes.Include(t=>t.Books).ToList();
    }
}
