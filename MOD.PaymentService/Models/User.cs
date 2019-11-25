using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.PaymentService.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public long Uid { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public long Mobile { get; set; }

        public string Password { get; set; }

        public bool Active { get; set; }
        public IEnumerable<Training> Training { get; set; }
        public IEnumerable<Payment> Payment { get; set; }
    }
}
