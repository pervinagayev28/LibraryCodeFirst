using DbModels.Entities.BaseEntities;
using System;
using System.Collections.Generic;

namespace ConsoleApp10.Concrets
{
    public partial class Faculty : IBaseEntity<int>
    {
        public Faculty()
        {
            Groups = new HashSet<Group>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Group> Groups { get; set; }
    }
}
