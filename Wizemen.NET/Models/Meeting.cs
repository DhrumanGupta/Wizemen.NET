using Newtonsoft.Json;

namespace Wizemen.NET.Models
{
    public class Meeting
    {
        [JsonProperty("meeting_id")] public string MeetingId { get; set; }

        [JsonProperty("topic")] public string Topic { get; set; }

        [JsonProperty("start_date")] public string StartDate { get; set; }

        [JsonProperty("start_time")] public string StartTime { get; set; }

        [JsonProperty("duration")] public string Duration { get; set; }

        [JsonProperty("agenda")] public string Agenda { get; set; }

        [JsonProperty("start_url")] public object StartUrl { get; set; }

        [JsonProperty("join_url")] public string JoinUrl { get; set; }

        [JsonProperty("meeting_password")] public string MeetingPassword { get; set; }

        [JsonProperty("attendees")] public object Attendees { get; set; }

        [JsonProperty("host")] public string Host { get; set; }
    }
}