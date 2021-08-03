using System;
using Newtonsoft.Json;

namespace Wizemen.NET.Dtos
{
    internal class EventDto
    {
        [JsonProperty("event_type")] public string EventType { get; set; }

        [JsonProperty("event_id")] public int EventId { get; set; }

        [JsonProperty("event_title")] public string EventTitle { get; set; }

        [JsonProperty("event_data")] public string EventData { get; set; }

        [JsonProperty("event_date")] public DateTime EventDate { get; set; }

        [JsonProperty("start_date")] public object StartDate { get; set; }

        [JsonProperty("end_date")] public DateTime EndDate { get; set; }

        [JsonProperty("event_time")] public object EventTime { get; set; }

        [JsonProperty("event_mid")] public object EventMid { get; set; }

        [JsonProperty("class_id")] public object ClassId { get; set; }

        [JsonProperty("class_code")] public object ClassCode { get; set; }

        [JsonProperty("class_name")] public object ClassName { get; set; }

        [JsonProperty("uid")] public object Uid { get; set; }

        [JsonProperty("start_time")] public object StartTime { get; set; }

        [JsonProperty("end_time")] public object EndTime { get; set; }

        [JsonProperty("student_id")] public object StudentId { get; set; }

        [JsonProperty("color_code")] public string ColorCode { get; set; }
    }
}