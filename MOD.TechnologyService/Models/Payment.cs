using MOD.TechnologyService.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.TechnologyService.Models
{
    [Table("Payment")]
    public class Payment
    {
        [Key]
        public long Pid { get; set; }
        //[ForeignKey("Training")]

        //public long TrainingID { get; set; }
        [ForeignKey("User")]
        public long Uid { get; set; }

        public double amount { get; set; }
        [ForeignKey("Mentor")]
        public long Mid { get; set; }

        public double Mentor_Amount { get; set; }
        public User User { get; set; }
        public Mentor Mentor { get; set; }
        //public Training Training {get;set;}

    }
}
