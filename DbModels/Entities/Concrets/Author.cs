using DbModels.Entities.BaseEntities;
using System;
using System.Collections.Generic;

namespace ConsoleApp10.Concrets
{
    public partial class Author : IBaseEntity<int>
    {
        public Author()
        {
            Books = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public virtual ICollection<Book> Books { get; set; }
    }
}
