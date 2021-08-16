using System;
using AutoMapper;
using Wizemen.NET.Profiles;

namespace Wizemen.NET.Services
{
    internal static class MappingService
    {
        private static readonly Lazy<IMapper> Lazy = new(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                // This line ensures that internal properties are also mapped over.
                cfg.ShouldMapProperty =
                    p => p.GetMethod is not null && (p.GetMethod.IsPublic || p.GetMethod.IsAssembly);
                
                cfg.AddProfile<ClassProfile>();
                cfg.AddProfile<MeetingProfile>();
                cfg.AddProfile<StudentProfile>();
                cfg.AddProfile<ClassAttendanceProfile>();
                cfg.AddProfile<EventProfile>();
                cfg.AddProfile<ClassScheduleProfile>();
                cfg.AddProfile<TeacherProfile>();
            });
            var mapper = config.CreateMapper();
            return mapper;
        });

        public static IMapper Mapper => Lazy.Value;
    }
}