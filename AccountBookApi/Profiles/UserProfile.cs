using System;
using AccountBookApi.Domain;
using AccountBookApi.DTO;
using AutoMapper;

namespace AccountBookApi.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, GetUserDTO>()
                .ForMember(
                    dest => dest.Age,
                    opt => opt.MapFrom(src => 5)
                );

            CreateMap<CreateUserDTO, User>();
        }
    }
}
