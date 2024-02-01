using ConsoleApp10.Concrets;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLibrary.Configurations.ConstraintConfigs
{
    internal class LibConfig : IEntityTypeConfiguration<Lib>
    {
        public void Configure(EntityTypeBuilder<Lib> builder)
        {
            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.FirstName).HasMaxLength(15);

            builder.Property(e => e.LastName).HasMaxLength(25);
        }
    }
}
