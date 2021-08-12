using System;
using Newtonsoft.Json;

namespace Wizemen.NET.Dtos
{
    internal class ClassScheduleDto
    {
        [JsonProperty("key_id")] public string Day { get; set; }

        [JsonProperty("start_date_display")] public string StartDate { get; set; } // dd/mm/yyyy

        [JsonProperty("class_code")] public string ClassCode { get; set; }

        [JsonProperty("class_id")] public string ClassId { get; set; }

        [JsonProperty("start_time")] public DateTime StartTime { get; set; } // hh:MM

        [JsonProperty("end_time")] public DateTime EndTime { get; set; } // hh:MM

        [JsonProperty("subject")] public string Subject { get; set; }

        [JsonProperty("teacher_full_name")] public string TeacherFullName { get; set; }

        [JsonProperty("starting_day")] public DateTime StartingDay { get; set; } // mm/dd/yyyy hh:MM:ss tt
    }
}