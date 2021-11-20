using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatAppAPI.ViewModel
{
    public class EmployeeVM
    {
        public int Id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string fullname { get; set; }
        public Boolean isActive { get; set; }
        public int CampanyId { get; set; }
    }
}
