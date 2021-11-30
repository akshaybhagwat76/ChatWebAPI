using AutoMapper;
using ChatAppAPI.Models;
using ChatAppAPI.ViewModel;
using ChatWebAPI.Models;
using ChatWebAPI.ViewModel;

namespace ChatWebAPI
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerVM>().ReverseMap();
            CreateMap<Chat_OneToOne, Chat_OneToOneVM>().ReverseMap();
        }
    }
}