﻿using ConsoleApp10.Concrets;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DbLibrary.Contexts
{
    public class MyDb:DbContext
    {
        public MyDb()
        {

        }

        public MyDb(DbContextOptions<MyDb> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Authors { get; set; } = null!;
        public virtual DbSet<Book> Books { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<SCard> SCards { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;



        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Faculty> Faculties { get; set; } = null!;
        public virtual DbSet<Group> Groups { get; set; } = null!;
        public virtual DbSet<Lib> Libs { get; set; } = null!;
        public virtual DbSet<Press> Presses { get; set; } = null!;
        public virtual DbSet<TCard> TCards { get; set; } = null!;
        public virtual DbSet<Teacher> Teachers { get; set; } = null!;
        public virtual DbSet<Theme> Themes { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                    .UseSqlServer("Data Source=DESKTOP-47DGCU6\\SQL;Initial Catalog=LibraryCodeFirst;User ID=MySql;Password=pervina9266_1;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }




    }
}
