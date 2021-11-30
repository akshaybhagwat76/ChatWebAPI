using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChatWebAPI.Models
{
    [Table("Chat_OneToOne")]
    public class Chat_OneToOne
    {
        [Key]
        public int ChatId { get; set; }
        public int EmployeeId { get; set; }
        public string CustomerId { get; set; }
        public String Message { get; set; }
        public String file { get; set; }
        public DateTime date { get; set; }
    }
}
