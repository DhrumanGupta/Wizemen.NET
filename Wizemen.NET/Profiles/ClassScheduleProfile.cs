using System;
using System.Globalization;
using AutoMapper;
using Wizemen.NET.Dtos;
using Wizemen.NET.Models;

namespace Wizemen.NET.Profiles
{
    internal class ClassScheduleProfile : Profile
    {
        public ClassScheduleProfile()
        {
            CreateMap<ClassScheduleDto, ClassSchedule>()
                .ForMember(x => x.StartDate,
                    x =>
                        x.MapFrom(y => DateTime.ParseExact(y.StartDate, "dd/MM/yyyy", CultureInfo.InvariantCulture)))
                .ForMember(x => x.ClassId,
                    x => x.MapFrom(y => int.Parse(y.ClassId)));
        }
    }
}