using Microsoft.EntityFrameworkCore;
using MODUserservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MODUserservice.Context
{
    public class MainContext:DbContext
    {
        public MainContext(DbContextOptions<MainContext> options) : base(options) { }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=DESKTOP-J33QLHE\SQLDB;Database=EmpDB;Trusted_Connection=True;");
        //}

        public DbSet<Mentor> mentors { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Technology> technology { get; set; }
        public DbSet<Training> training { get; set; }
        public DbSet<Payment> payment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User
            {
                Uid=12,
                Name="D",
                Email="abc@gmail.com",
                Mobile=9876543212,
                Password="234",
                Active=true
            }
                );
            modelBuilder.Entity<Mentor>().HasData(new Mentor
            {
                Mid = 12,
                Mname = "DB",
                Email = "abc@gmail.com",
                Password = "234",
                Mobile = 9876543245,
                Primary_skill="DotNet",
                timeslot="2 to 6",
                availability =true,
                Active = true
            }
                );

        }


    }
}
