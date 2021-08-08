using AutoMapper;
using Wizemen.NET.Dtos;
using Wizemen.NET.Models;

namespace Wizemen.NET.Profiles
{
    internal class ClassAttendanceProfile : Profile
    {
        public ClassAttendanceProfile()
        {
            CreateMap<ClassAttendanceDto, ClassAttendance>()
                .ForMember(x => x.TotalClasses,
                    x => x.MapFrom(y => y.ClassPeriod));
        }
    }
}