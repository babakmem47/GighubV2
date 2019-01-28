using AutoMapper;
using GighubV2.Dtos;
using GighubV2.Models;

namespace GighubV2.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Genre, GenreDto>();
            Mapper.CreateMap<ApplicationUser, ApplicationUserDto>();
            Mapper.CreateMap<Gig, GigDto>();
            Mapper.CreateMap<Notification, NotificationDto>();
        }
    }
}