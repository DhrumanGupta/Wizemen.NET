using System;
using Newtonsoft.Json;

namespace Wizemen.NET.Dtos
{
    internal class StudentDto
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("student_first_name")]
        public string FirstName { get; set; }

        [JsonProperty("student_middle_name")]
        public object MiddleName { get; set; }

        [JsonProperty("student_last_name")]
        public string LastName { get; set; }

        [JsonProperty("birthday")]
        public DateTime Birthday { get; set; }

        [JsonProperty("student_email")]
        public string StudentEmail { get; set; }

        [JsonProperty("parent1_first_name")]
        public string Parent1FirstName { get; set; }

        [JsonProperty("parent1_last_name")]
        public string Parent1LastName { get; set; }

        [JsonProperty("parent1_email")]
        public string Parent1Email { get; set; }

        [JsonProperty("parent1_mobile")]
        public string Parent1Mobile { get; set; }

        [JsonProperty("parent2_first_name")]
        public string Parent2FirstName { get; set; }

        [JsonProperty("parent2_last_name")]
        public string Parent2LastName { get; set; }

        [JsonProperty("parent2_email")]
        public string Parent2Email { get; set; }

        [JsonProperty("parent2_mobile")]
        public string Parent2Mobile { get; set; }

        [JsonProperty("img_path")]
        public string ImageUrl { get; set; }

        [JsonProperty("school_level")]
        public string SchoolLevel { get; set; }

        [JsonProperty("homeroom_teacher_name")]
        public string HomeroomTeacherName { get; set; }

        [JsonProperty("resident_status")]
        public string ResidentStatus { get; set; }
    }
}