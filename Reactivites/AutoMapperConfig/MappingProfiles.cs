using AutoMapper;
using Reactivities.Models;
using Reactivities.Models.DTO;

namespace Reactivities.AutoMapperConfig
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {

            CreateMap<Activity, ActivityDto>().ReverseMap();
        }
    }
}
