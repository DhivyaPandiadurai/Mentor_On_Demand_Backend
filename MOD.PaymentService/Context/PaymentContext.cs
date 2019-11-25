using Microsoft.EntityFrameworkCore;
using MOD.PaymentService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.PaymentService.Context
{
    public class PaymentContext:DbContext
    {

        public  PaymentContext(DbContextOptions<PaymentContext> options) : base(options) { }
       

        public DbSet<Mentor> mentors { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Technology> technology { get; set; }
        public DbSet<Training> training { get; set; }
        public DbSet<Payment> payment { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Payment>().HasData(new Payment
            {
                Pid=12,
                Uid=3,
                amount=34567.89,
                Mid=23,
                Mentor_Amount=4589.00

            }
                );

        }
    }
}
