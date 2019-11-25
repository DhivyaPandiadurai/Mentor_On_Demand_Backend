using Microsoft.EntityFrameworkCore;
using MOD.AuthenticateService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.AuthenticateService.Context
{
    public class LoginContext:DbContext
    {

        public LoginContext(DbContextOptions<LoginContext> options) : base(options) { }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=DESKTOP-J33QLHE\SQLDB;Database=EmpDB;Trusted_Connection=True;");
        //}



        public DbSet<Mentor> mentors { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Technology> technology { get; set; }
        public DbSet<Training> training { get; set; }
        public DbSet<Payment> payment { get; set; }

    }
}
