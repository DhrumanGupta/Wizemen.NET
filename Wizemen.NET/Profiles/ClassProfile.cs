using AutoMapper;
using Wizemen.NET.Dtos;
using Wizemen.NET.Models;

namespace Wizemen.NET.Profiles
{
    internal class ClassProfile : Profile
    {
        public ClassProfile()
        {
            CreateMap<ClassDto, Class>();
        }
    }
}