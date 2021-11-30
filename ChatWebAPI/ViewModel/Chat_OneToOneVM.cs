using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatWebAPI.ViewModel
{
    public class Chat_OneToOneVM
    {
        public int ChatId { get; set; }
        public int EmployeeId { get; set; }

        public String type { get; set; }
        //public String Type { get; set; }
        public int CustomerId { get; set; }
        public String Message { get; set; }
        public String file { get; set; }
        public String date { get; set; }
    }
    public class ChatMessage
    {
        public string Chatid { get; set; }
        public string message { get; set; }
        public String type { get; set; }
        public DateTime Sent { get; set; }
        public string fullname { get; set; }
        public int clientId { get; set; }
        public int EmployeeId { get; set; }
        public string username { get; set; }
        public string email { get; set; }
    }
}
