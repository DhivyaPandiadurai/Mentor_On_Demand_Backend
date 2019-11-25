
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.PaymentService.Models
{
    [Table("Mentor")]
    public class Mentor
    {
        [Key]
        public long Mid { get; set; }

        public string Mname { get; set; }

        public long Mobile { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }

        public int exp { get; set; }

        public string Primary_skill { get; set; }

        public string timeslot { get; set; }

        public bool availability { get; set; }

        public bool Active { get; set; }
        public IEnumerable<Payment> Payment { get; set; }

        public IEnumerable<Training> Training { get; set; }
    }
}
