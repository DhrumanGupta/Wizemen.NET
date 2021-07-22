using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Wizemen.NET.DtoModels
{
    internal class MeetingDto
    {
        [JsonProperty("topic")] public string Topic { get; set; }

        [JsonProperty("start_date")] public DateTime StartDate { get; set; }

        [JsonProperty("start_time")] public DateTime StartTime { get; set; }

        [JsonProperty("duration")] public int Duration { get; set; }

        [JsonProperty("agenda")] public string Agenda { get; set; }

        [JsonProperty("join_url")] public string JoinUrl { get; set; }

        [JsonProperty("meeting_password")] public string MeetingPassword { get; set; }

        [JsonProperty("host")] public string Host { get; set; }
    }
}