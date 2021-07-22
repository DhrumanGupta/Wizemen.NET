using System;
using Newtonsoft.Json;
using Wizemen.NET.DtoModels;

namespace Wizemen.NET.Models
{
    public class Meeting
    {
        public string Topic { get; set; }
        
        public DateTime StartTime { get; set; }

        public int Duration { get; set; }

        public string Agenda { get; set; }

        public string JoinUrl { get; set; }
        
        public string Id => JoinUrl.Split('/')[^1].Split('?')[0];

        public string Password { get; set; }

        public string Host { get; set; }

        internal static Meeting FromDto(MeetingDto dto)
        {
            var meeting = new Meeting {Topic = dto.Topic};

            var time = dto.StartTime;
            meeting.StartTime = dto.StartDate.AddHours(time.Hour).AddMinutes(time.Minute).AddSeconds(time.Second);

            meeting.Duration = dto.Duration;
            meeting.Agenda = dto.Agenda;
            meeting.JoinUrl = dto.JoinUrl;
            meeting.Password = dto.MeetingPassword;
            meeting.Host = dto.Host;
                
            return meeting;
        }
    }
}