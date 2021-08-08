using Newtonsoft.Json;

namespace Wizemen.NET.Dtos
{
    internal class ClassAttendanceDto
    {
        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("class_period")] public int ClassPeriod { get; set; }

        [JsonProperty("teacher_full_name")] public string TeacherFullName { get; set; }

        [JsonProperty("Present")] public int Present { get; set; }

        [JsonProperty("Present_inclass")] public int PresentInClass { get; set; }

        [JsonProperty("Present_online")] public int PresentOnline { get; set; }

        [JsonProperty("Absent_Unexcused")] public int AbsentUnexcused { get; set; }

        [JsonProperty("Absent_Excused")] public int AbsentExcused { get; set; }

        [JsonProperty("Student_Illness")] public int StudentIllness { get; set; }

        [JsonProperty("Sent_Home")] public int SentHome { get; set; }

        [JsonProperty("Exeat")] public int Exeat { get; set; }

        [JsonProperty("Late_Unexcused")] public int LateUnexcused { get; set; }

        [JsonProperty("Late_Excused")] public int LateExcused { get; set; }

        [JsonProperty("Not_Expected")] public int NotExpected { get; set; }

        [JsonProperty("Early_Dismissal")] public int EarlyDismissal { get; set; }

        [JsonProperty("School_Trip")] public int SchoolTrip { get; set; }

        [JsonProperty("Representing_School")] public int RepresentingSchool { get; set; }

        [JsonProperty("Exam_Leave")] public int ExamLeave { get; set; }

        [JsonProperty("ALS")] public int Als { get; set; }

        [JsonProperty("Suspended")] public int Suspended { get; set; }
    }
}