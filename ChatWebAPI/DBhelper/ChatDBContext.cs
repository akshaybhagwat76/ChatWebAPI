using ChatAppAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatAppAPI.DBHelper
{
    public class ChatDBContext : DbContext
    {

        public ChatDBContext(DbContextOptions<ChatDBContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}
