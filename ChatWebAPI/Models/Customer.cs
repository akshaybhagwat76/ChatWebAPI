using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChatAppAPI.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int id { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public int ClientId { get; set; }
        public string Phone { get; set; }
        public int EmployeeId { get; set; }
        public string type { get; set; }
        public string message { get; set; }
    }
}
