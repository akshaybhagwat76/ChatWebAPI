using ChatAppAPI.Models;
using ChatAppAPI.ViewModel;
using ChatWebAPI.Models;
using ChatWebAPI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatAppAPI.Services.Interface
{
    public interface IGetUserslist
    {
        Task<List<CustomerVM>> GetCustomerList();
        Task<List<CustomerVM>> SearchCustomer(string prefix);
        Task<Chat_OneToOneVM> ChatCustomer(Chat_OneToOneVM Model);
        Task<List<Customer>> GetMessages(int id);
        Task<List<Customer>> GetCustomerAllMsg(int id);
    }
}
