using AutoMapper;
using ChatAppAPI.Models;
using ChatAppAPI.ViewModel;

namespace ChatWebAPI
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerVM>().ReverseMap();
        }
    }
}