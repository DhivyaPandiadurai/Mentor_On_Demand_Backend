using Microsoft.EntityFrameworkCore;
using MOD.TrainingService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.TrainingService.Context
{
    public class TrainingContext : DbContext
    {
        public TrainingContext(DbContextOptions<TrainingContext> options) : base(options) { }

        public DbSet<Mentor> mentors { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Technology> technology { get; set; }
        public DbSet<Training> training { get; set; }
        public DbSet<Payment> payment { get; set; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Training>().HasData(new Training
            {
              TrainingID=1,
                Uid=1234,
                Mid=122,
                SkillId=345,
                StartDate=DateTime.Parse("11-2-2017"),
                EndDate=DateTime.Parse("2-2-2018"),
                timeslot="evening",
                status="Not Completed",
                Progress=25,
                rating=3.5f
            }
                );

        }

    }
}
