using AutoMapper;
using Wizemen.NET.Dtos;
using Wizemen.NET.Models;

namespace Wizemen.NET.Profiles
{
    internal class MeetingProfile : Profile
    {
        public MeetingProfile()
        {
            CreateMap<MeetingDto, Meeting>()
                .ForMember(x => x.StartTime,
                    x => x.MapFrom((y, a) => 
                        y.StartDate.AddHours(y.StartTime.Hour).AddMinutes(y.StartTime.Minute).AddSeconds(
                            y.StartTime.Second)))
                .ForMember(x => x.Password,
                    x => x.MapFrom(y => y.MeetingPassword));
        }
    }
}