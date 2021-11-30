using AutoMapper;
using ChatAppAPI.DBHelper;
using ChatAppAPI.Models;
using ChatAppAPI.Services.Interface;
using ChatAppAPI.ViewModel;
using ChatWebAPI.Models;
using ChatWebAPI.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatAppAPI.Services
{
    public class GetUserListService : IGetUserslist
    {
        private readonly ChatDBContext _context;
        private readonly IMapper _mapper;
        public GetUserListService(ChatDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<CustomerVM>> GetCustomerList()
        {
            List<Customer> customerList = await _context.Customers.ToListAsync();

            List<CustomerVM> data = _mapper.Map<List<Customer>, List<CustomerVM>>(customerList);

            return data;
        }
        public async Task<List<CustomerVM>> SearchCustomer(String Prefix)
        {
            List<Customer> customerList = new List<Customer>();
            if (Prefix == null)
            {
                 customerList = await _context.Customers.ToListAsync();
            }
            else { 
                 customerList = await _context.Customers.Where(x => x.Fullname.ToLower().Contains(Prefix.Trim().ToLower())).ToListAsync();
            }

            List<CustomerVM> data = _mapper.Map<List<Customer> , List<CustomerVM>> (customerList);

            return data;
        }
        public async Task<Chat_OneToOneVM> ChatCustomer(Chat_OneToOneVM Model)
        {
            if (Model != null)
            {
                Chat_OneToOne data = _mapper.Map<Chat_OneToOneVM, Chat_OneToOne>(Model);
                _context.ChatOnetoOne.Add(data);
                _context.SaveChanges();
            }
            return Model;
        }
        public async Task<List<Customer>> GetMessages(int id)
        {
            List<Customer> list = new List<Customer>();
            if (id != null)
            {
                
                list = _context.Customers.Where(x => x.EmployeeId == id).ToList();
            }
            return list;
        }
        public async Task<List<Customer>> GetCustomerAllMsg(int id)
        {
            List<Customer> list = new List<Customer>();
            if (id != null)
            {
                list = _context.Customers.Where(x => x.ClientId == id).ToList();
            }
            return list;
        }
    }
}
