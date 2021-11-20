using AutoMapper;
using ChatAppAPI.DBHelper;
using ChatAppAPI.Models;
using ChatAppAPI.Services.Interface;
using ChatAppAPI.ViewModel;
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
    }
}
