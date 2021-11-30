using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChatAppAPI.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string fullname { get; set; }
        public Boolean isActive { get; set; }
        public int EmployeeId { get; set; }
        public string message { get; set; }
        public string type { get; set; }
        public int clientId { get; set; }
    }
}
