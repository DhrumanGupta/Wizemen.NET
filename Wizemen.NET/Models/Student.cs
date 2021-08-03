using System;
using Newtonsoft.Json;

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
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// The student's first name
        /// </summary>
        [JsonProperty("student_first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// The student's middle name (null if not found)
        /// </summary>
        [JsonProperty("student_middle_name")]
        public object MiddleName { get; set; }

        /// <summary>
        /// The student's last name (null if not found)
        /// </summary>
        [JsonProperty("student_last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// The student's birthday
        /// </summary>
        [JsonProperty("birthday")]
        public DateTime Birthday { get; set; }

        /// <summary>
        /// The student's school email
        /// </summary>
        [JsonProperty("student_email")]
        public string StudentEmail { get; set; }

        /// <summary>
        /// The student's first parent's first name
        /// </summary>
        [JsonProperty("parent1_first_name")]
        public string Parent1FirstName { get; set; }

        /// <summary>
        /// The student's first parent's last name
        /// </summary>
        [JsonProperty("parent1_last_name")]
        public string Parent1LastName { get; set; }

        /// <summary>
        /// The student's first parent's email
        /// </summary>
        [JsonProperty("parent1_email")]
        public string Parent1Email { get; set; }

        /// <summary>
        /// The student's first parent's mobile no.
        /// </summary>
        [JsonProperty("parent1_mobile")]
        public string Parent1Mobile { get; set; }

        /// <summary>
        /// The student's second parent's first name
        /// </summary>
        [JsonProperty("parent2_first_name")]
        public string Parent2FirstName { get; set; }

        /// <summary>
        /// The student's second parent's second name
        /// </summary>
        [JsonProperty("parent2_last_name")]
        public string Parent2LastName { get; set; }

        /// <summary>
        /// The student's second parent's email
        /// </summary>
        [JsonProperty("parent2_email")]
        public string Parent2Email { get; set; }

        /// <summary>
        /// The student's second parent's mobile no.
        /// </summary>
        [JsonProperty("parent2_mobile")]
        public string Parent2Mobile { get; set; }

        /// <summary>
        /// The image URL for the student's Wizemen image
        /// </summary>
        [JsonProperty("img_path")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// The student's school level ("Senior School", etc) (Not an enum since middle school is not tested)
        /// </summary>
        [JsonProperty("school_level")]
        public string SchoolLevel { get; set; }

        /// <summary>
        /// The name of the student's Homeroom Teacher
        /// </summary>
        [JsonProperty("homeroom_teacher_name")]
        public string HomeroomTeacherName { get; set; }

        /// <summary>
        /// The residency status of the student ("Day Student", etc) (Not an enum since other status are not tested)
        /// </summary>
        [JsonProperty("resident_status")]
        public string ResidentStatus { get; set; }
    }
}