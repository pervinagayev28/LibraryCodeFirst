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
    internal class S_CardConfig : IEntityTypeConfiguration<SCard>
    {
        public void Configure(EntityTypeBuilder<SCard> builder)
        {
            builder.ToTable("S_Cards");

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.DateIn).HasColumnType("datetime");

            builder.Property(e => e.DateOut).HasColumnType("datetime");

            builder.Property(e => e.IdBook).HasColumnName("Id_Book");

            builder.Property(e => e.IdLib).HasColumnName("Id_Lib");

            builder.Property(e => e.IdStudent).HasColumnName("Id_Student");

            builder.HasOne(d => d.IdBookNavigation)
                .WithMany(p => p.SCards)
                .HasForeignKey(d => d.IdBook)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_S_Cards_Book");

            builder.HasOne(d => d.IdLibNavigation)
                .WithMany(p => p.SCards)
                .HasForeignKey(d => d.IdLib)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_S_Cards_Lib");

            builder.HasOne(d => d.IdStudentNavigation)
                .WithMany(p => p.SCards)
                .HasForeignKey(d => d.IdStudent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_S_Cards_Stud");
        }
    }
}
