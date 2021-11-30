using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatWebAPI.DBhelper
{
    public class Messages
    {
            public string id { get; set; }
            public string fullname { get; set; }
            public string Email { get; set; }
            public string message { get; set; }
            public DateTime date { get; set; }
    }
}
