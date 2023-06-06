using API.DTO;
using API.Entities;
using AutoMapper;

namespace api.Helpers;

public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<AppUser, MemberDto>()
                 .ForMember(dest => dest.url, opt => opt.MapFrom(src => src.Photos.FirstOrDefault(x => x.isMain).url));
                 
        CreateMap<Photo, PhotoDto>();
    }

}