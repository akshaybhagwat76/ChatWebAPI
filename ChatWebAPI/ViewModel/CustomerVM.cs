using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChatAppAPI.ViewModel
{
    public class CustomerVM
    {
        public int id { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public int CompanyId { get; set; }
        public string Phone { get; set; }
    }
}
