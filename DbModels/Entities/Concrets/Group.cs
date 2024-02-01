using DbModels.Entities.BaseEntities;
using System;
using System.Collections.Generic;

namespace ConsoleApp10.Concrets
{
    public partial class Group : IBaseEntity<int>
    {
        public Group()
        {
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int IdFaculty { get; set; }

        public virtual Faculty IdFacultyNavigation { get; set; } = null!;
        public virtual ICollection<Student> Students { get; set; }
    }
}
