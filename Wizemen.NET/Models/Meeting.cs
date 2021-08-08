using System;

namespace Wizemen.NET.Models
{
    /// <summary>
    /// A meeting a user can join
    /// </summary>
    public class Meeting
    {
        /// <summary>
        /// The topic of the meeting
        /// </summary>
        public string Topic { get; set; }
        
        /// <summary>
        /// The time the meeting starts
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// The duration of the meeting
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// The agenda set by the teacher for the meeting
        /// </summary>
        public string Agenda { get; set; }

        /// <summary>
        /// The URL to join the meeting with (contains id and pwd for zoom)
        /// </summary>
        public string JoinUrl { get; set; }
        
        /// <summary>
        /// The zoom meeting id
        /// </summary>
        public string Id => JoinUrl.Split('/')[^1].Split('?')[0];

        /// <summary>
        /// The zoom meeting password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// The name of the user who is hosting the meeting
        /// </summary>
        public string Host { get; set; }
    }
}