﻿using Wizemen.NET.DtoModels;

namespace Wizemen.NET.Models
{
    /// <summary>
    /// A wizemen class a user is enrolled in
    /// </summary>
    public class Class
    {
        /// <summary>
        /// Name of the program the user is in (PYP, MYP, DP)
        /// </summary>
        public string ProgramName { get; set; }

        /// <summary>
        /// The user's current grade
        /// </summary>
        public string Grade { get; set; }

        /// <summary>
        /// The id of the class
        /// </summary>
        public int ClassId { get; set; }

        /// <summary>
        /// The id of the class's teacher
        /// </summary>
        public int TeacherId { get; set; }
        
        /// <summary>
        /// The Name of the class's teacher
        /// </summary>
        public string TeacherName { get; set; }

        /// <summary>
        /// The class's code
        /// </summary>
        public string ClassCode { get; set; }

        /// <summary>
        /// The subject of the class
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// The course of the class
        /// </summary>
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