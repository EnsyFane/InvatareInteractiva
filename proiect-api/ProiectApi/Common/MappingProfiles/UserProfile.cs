using AutoMapper;
using Common.DTOs;
using Common.Entities;
using Common.ViewModels;

namespace Common.MappingProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserViewModel, UserDto>().ReverseMap();
            CreateMap<UserDto, User>().ReverseMap();
        }
    }
}
