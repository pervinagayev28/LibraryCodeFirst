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
    internal class GroupRepository : GenericRepository<Group, int>, IGroupRepository
    {
        public Group ?GetByName(string name) =>
            context.Groups.FirstOrDefault(g=>g.Name==name);

        public IEnumerable<Group> GetFullData() =>
            context.Groups.Include(g=>g.Students).ToList();
    }
}
