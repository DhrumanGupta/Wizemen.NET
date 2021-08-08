using AutoMapper;
using Wizemen.NET.Dtos;
using Wizemen.NET.Models;

namespace Wizemen.NET.Profiles
{
    internal class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<StudentDto, Student>();
        }
    }
}