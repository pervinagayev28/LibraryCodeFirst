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
    internal class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.FirstName).HasMaxLength(15);

            builder.Property(e => e.IdGroup).HasColumnName("Id_Group");

            builder.Property(e => e.LastName).HasMaxLength(25);

            builder.HasOne(d => d.IdGroupNavigation)
                .WithMany(p => p.Students)
                .HasForeignKey(d => d.IdGroup)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Students_Group");
        }
    }
}
