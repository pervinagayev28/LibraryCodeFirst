using DbModels.Entities.BaseEntities;
using System;
using System.Collections.Generic;

namespace ConsoleApp10.Concrets
{
    public partial class Department : IBaseEntity<int>
    {
        public Department()
        {
            Teachers = new HashSet<Teacher>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
