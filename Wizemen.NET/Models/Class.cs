using Wizemen.NET.DtoModels;

namespace Wizemen.NET.Models
{
    public class Class
    {
        public string ProgramName { get; set; }

        public string Grade { get; set; }

        public int ClassId { get; set; }

        public int TeacherId { get; set; }

        public string TeacherName { get; set; }

        public string ClassCode { get; set; }

        public string Subject { get; set; }

        public string Course { get; set; }

        internal static Class FromDto(ClassDto dto)
        {
            return new()
            {
                ProgramName = dto.Program,
                Grade = dto.Grade,
                ClassCode = dto.ClassCode,
                ClassId = dto.ClassId,
                TeacherName = dto.TeacherName,
                TeacherId = dto.TeacherId,
                Subject = dto.Subject,
                Course = dto.Course
            };
        }
    }
}