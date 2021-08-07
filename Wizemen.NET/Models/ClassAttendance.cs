using Newtonsoft.Json;

namespace Wizemen.NET.Models
{
    /// <summary>
    /// Attendance data for a class
    /// </summary>
    public class ClassAttendance
    {
        /// <summary>
        /// The subject the attendance is regarding
        /// </summary>
        [JsonProperty("subject")] public string Subject { get; set; }

        [JsonProperty("class_period")] public string ClassPeriod { get; set; }

        [JsonProperty("teacher_full_name")] public string TeacherFullName { get; set; }

        [JsonProperty("Present")] public string Present { get; set; }

        [JsonProperty("Present_inclass")] public string PresentInclass { get; set; }

        [JsonProperty("Present_online")] public string PresentOnline { get; set; }

        [JsonProperty("Absent_Unexcused")] public string AbsentUnexcused { get; set; }

        [JsonProperty("Absent_Excused")] public string AbsentExcused { get; set; }

        [JsonProperty("Student_Illness")] public string StudentIllness { get; set; }

        [JsonProperty("Sent_Home")] public string SentHome { get; set; }

        [JsonProperty("Exeat")] public string Exeat { get; set; }

        [JsonProperty("Late_Unexcused")] public string LateUnexcused { get; set; }

        [JsonProperty("Late_Excused")] public string LateExcused { get; set; }

        [JsonProperty("Not_Expected")] public string NotExpected { get; set; }

        [JsonProperty("Early_Dismissal")] public string EarlyDismissal { get; set; }

        [JsonProperty("School_Trip")] public string SchoolTrip { get; set; }

        [JsonProperty("Representing_School")] public string RepresentingSchool { get; set; }

        [JsonProperty("Exam_Leave")] public string ExamLeave { get; set; }

        [JsonProperty("ALS")] public string ALS { get; set; }

        [JsonProperty("Suspended")] public string Suspended { get; set; }
    }
}