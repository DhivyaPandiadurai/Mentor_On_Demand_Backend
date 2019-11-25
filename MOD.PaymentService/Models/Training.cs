using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.PaymentService.Models
{
    [Table("Training")]
    public class Training
    {
        [Key]
        public long TrainingID { get; set; }
        [ForeignKey("User")]
        public long Uid { get; set; }
        [ForeignKey("Mentor")]
        public long Mid { get; set; }
        [ForeignKey("Technology")]
        public long SkillId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string timeslot { get; set; }

        public string status { get; set; }

        public long Progress { get; set; }

        public float rating { get; set; }
        public User User { get; set; }
        public Mentor Mentor { get; set; }
        //public IEnumerable<Payment> Payment { get; set; }
        public Technology Technology { get; set; }


    }

}

