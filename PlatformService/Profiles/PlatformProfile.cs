using AutoMapper;
using PlatformService.DTOS;
using PlatformService.Models;

namespace PlatformService.Profiles
{
    public class PlatformProfile : Profile
    {
        public PlatformProfile()
        {
            CreateMap<Platform, PlatformReadDTO>();
            CreateMap<PlatfromCreateDTO, PlatformReadDTO>();
        }
    }
}
