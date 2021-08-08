using AutoMapper;
using Wizemen.NET.Dtos;
using Wizemen.NET.Models;

namespace Wizemen.NET.Profiles
{
    internal class EventProfile : Profile
    {
        public EventProfile()
        {
            CreateMap<EventDto, Event>()
                .ForMember(x => x.Type,
                    x => x.MapFrom(y => y.EventType))
                .ForMember(x => x.Id,
                    x => x.MapFrom(y => y.EventId))
                .ForMember(x => x.Title,
                    x => x.MapFrom(y => y.EventTitle))
                .ForMember(x => x.Data,
                    x => x.MapFrom(y => y.EventData))
                .ForMember(x => x.StartDate,
                    x => x.MapFrom(y => y.EventDate));
        }
    }
}