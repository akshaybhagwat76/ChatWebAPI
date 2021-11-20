using ChatAppAPI.Models;
using ChatAppAPI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatAppAPI.Services.Interface
{
    public interface IGetUserslist
    {
        Task<List<CustomerVM>> GetCustomerList();
    }
}
