using AutoMapper;
using ChatAppAPI.DBHelper;
using ChatAppAPI.Models;
using ChatWebAPI.DBhelper;
using ChatWebAPI.Models;
using ChatWebAPI.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        private ChatDBContext _dbContext;
        private UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;
        public ChatHub(ChatDBContext context, IMapper mapper)
        {
            _dbContext = context;
            _mapper = mapper;
        }
        public override Task OnConnectedAsync()
        {
            Console.WriteLine(Context.ConnectionId);
            return base.OnConnectedAsync();
        }
        public override Task OnDisconnectedAsync(Exception exception)
        {
            Console.WriteLine(Context.ConnectionId);
            return base.OnDisconnectedAsync(exception);
        }
        public async Task NewMessage(ChatMessage mesg)
        {
            //var anon = _dbContext.ChatOnetoOne.Where(x => x.ChatId == Convert.ToInt32(mesg.Chatid)).ToList().FirstOrDefault();
            //  mesg.Chatid = anon.ChatId.ToString();
            // anon.seenByUser = false;
            try
            {
                var msg = new Employee
                {
                    message = mesg.message,
                    username = mesg.username,
                    type = mesg.type,
                    email = mesg.email,
                    fullname = mesg.fullname,
                    isActive = false,
                    EmployeeId = mesg.EmployeeId,
                    clientId = mesg.clientId,
                };
                _dbContext.Employees.Add(msg);
                _dbContext.SaveChanges();
                var custmsg = new Customer
                {
                    message = mesg.message,
                    Fullname = mesg.fullname,
                    type = "received",
                    Email = mesg.email,
                    ClientId = mesg.clientId,
                    Phone = "",
                    EmployeeId = msg.EmployeeId,
                };
                _dbContext.Customers.Add(custmsg);
                _dbContext.SaveChanges();
                await Clients.All.SendAsync("MessageReceived", mesg);
            }
            catch (Exception ex)
            {

                throw ex; 
            }
        }

    }
}
