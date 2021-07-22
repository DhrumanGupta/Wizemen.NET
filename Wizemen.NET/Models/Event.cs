using System;
using System.Xml;
using Wizemen.NET.DtoModels;

namespace Wizemen.NET.Models
{
    public class Event
    {
        public string Type { get; set; }
        
        public int Id { get; set; }
        
        public string Title { get; set; }
        
        public string Data { get; set; }
        
        public DateTime StartDate { get; set; }   

        public DateTime EndDate { get; set; }

        public string ColorCode { get; set; }

        public static Event FromDto(EventDto dto)
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