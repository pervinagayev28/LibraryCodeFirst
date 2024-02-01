using DbModels.Entities.BaseEntities;
using System;
using System.Collections.Generic;

namespace ConsoleApp10.Concrets
{
    public partial class Lib : IBaseEntity<int>
    {
        public Lib()
        {
            SCards = new HashSet<SCard>();
            TCards = new HashSet<TCard>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public virtual ICollection<SCard> SCards { get; set; }
        public virtual ICollection<TCard> TCards { get; set; }
    }
}
