using System;
using System.Xml;
using Wizemen.NET.Dtos;

namespace Wizemen.NET.Models
{
    /// <summary>
    /// An event for a user
    /// </summary>
    public class Event
    {
        /// <summary>
        /// The type of event
        /// </summary>
        public string Type { get; set; }
        
        /// <summary>
        /// The id of the event
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// The event's Title
        /// </summary>
        public string Title { get; set; }
        
        /// <summary>
        /// Additional data (eg: description) for the event
        /// </summary>
        public string Data { get; set; }
        
        /// <summary>
        /// The start date for the event
        /// </summary>
        public DateTime StartDate { get; set; }   
        
        /// <summary>
        /// The end date for the event
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// The color code the event is displayed in
        /// </summary>
        public string ColorCode { get; set; }

        internal static Event FromDto(EventDto dto)
        {
            return new()
            {
                Type = dto.EventType,
                Id = dto.EventId,
                Title = dto.EventTitle,
                Data = dto.EventData,
                StartDate = dto.EventDate,
                EndDate = dto.EndDate,
                ColorCode = dto.ColorCode
            };
        }
    }
}