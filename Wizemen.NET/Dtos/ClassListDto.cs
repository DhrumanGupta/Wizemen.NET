using Newtonsoft.Json;

namespace Wizemen.NET.Dtos
{
    internal class ClassListDto
    {
        [JsonProperty("program")] public string ProgramName { get; set; }

        [JsonProperty("grade")] public string Grade { get; set; }

        [JsonProperty("class_id")] public int Id { get; set; }

        [JsonProperty("teacher_id")] public int TeacherId { get; set; }

        [JsonProperty("teacher_name")] public string TeacherName { get; set; }

        [JsonProperty("class_code")] public string Code { get; set; }

        [JsonProperty("subject")] public string Subject { get; set; }

        [JsonProperty("course")] public string Name { get; set; }

    }
}