using System;

namespace Wizemen.NET.Models
{
    /// <summary>
    /// The student object containing all public details of a student
    /// </summary>
    public class Student
    {
        /// <summary>
        /// The user Id of the student
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// The student's first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The student's middle name (null if not found)
        /// </summary>
        public object MiddleName { get; set; }

        /// <summary>
        /// The student's last name (null if not found)
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The student's birthday
        /// </summary>
        public DateTime Birthday { get; set; }

        /// <summary>
        /// The student's school email
        /// </summary>
        public string StudentEmail { get; set; }

        /// <summary>
        /// The student's first parent's first name
        /// </summary>
        public string Parent1FirstName { get; set; }

        /// <summary>
        /// The student's first parent's last name
        /// </summary>
        public string Parent1LastName { get; set; }

        /// <summary>
        /// The student's first parent's email
        /// </summary>
        public string Parent1Email { get; set; }

        /// <summary>
        /// The student's first parent's mobile no.
        /// </summary>
        public string Parent1Mobile { get; set; }

        /// <summary>
        /// The student's second parent's first name
        /// </summary>
        public string Parent2FirstName { get; set; }

        /// <summary>
        /// The student's second parent's second name
        /// </summary>
        public string Parent2LastName { get; set; }

        /// <summary>
        /// The student's second parent's email
        /// </summary>
        public string Parent2Email { get; set; }

        /// <summary>
        /// The student's second parent's mobile no.
        /// </summary>
        public string Parent2Mobile { get; set; }

        /// <summary>
        /// The image URL for the student's Wizemen image
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// The student's school level ("Senior School", etc) (Not an enum since middle school is not tested)
        /// </summary>
        public string SchoolLevel { get; set; }

        /// <summary>
        /// The name of the student's Homeroom Teacher
        /// </summary>
        public string HomeroomTeacherName { get; set; }

        /// <summary>
        /// The residency status of the student ("Day Student", etc) (Not an enum since other status are not tested)
        /// </summary>
        public string ResidentStatus { get; set; }
    }
}