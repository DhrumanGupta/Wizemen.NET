using Newtonsoft.Json;

namespace Wizemen.NET.Dtos
{
    internal class ClassDto
    {
        [JsonProperty("program")] public string Program { get; set; }

        [JsonProperty("grade")] public string Grade { get; set; }

        [JsonProperty("class_id")] public int ClassId { get; set; }

        [JsonProperty("teacher_id")] public int TeacherId { get; set; }

        [JsonProperty("teacher_name")] public string TeacherName { get; set; }

        [JsonProperty("class_code")] public string ClassCode { get; set; }

        [JsonProperty("subject")] public string Subject { get; set; }

        [JsonProperty("course")] public string Course { get; set; } }
}