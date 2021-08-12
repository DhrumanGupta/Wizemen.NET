using System;

namespace Wizemen.NET.Models
{
    /// <summary>
    /// Represents a cell for a weekly class schedule
    /// </summary>
    public class ClassSchedule
    {
        /// <summary>
        /// The day the object represents. Possible values: "Monday", "Tuesday", "Wednesday", "Thursday", "Friday"
        /// </summary>
        public string Day { get; set; }

        /// <summary>
        /// The date of the scheduled class
        /// </summary>
        public DateTime StartDate { get; set; } // dd/mm/yyyy

        /// <summary>
        /// The class code of the scheduled class
        /// </summary>
        public string ClassCode { get; set; }

        /// <summary>
        /// The class id of the scheduled class
        /// </summary>
        public int ClassId { get; set; }

        /// <summary>
        /// The start time (only hh/mm are relevant) of the scheduled class
        /// </summary>
        public DateTime StartTime { get; set; } // hh:MM

        /// <summary>
        /// The end time (only hh/mm are relevant) of the scheduled class
        /// </summary>
        public DateTime EndTime { get; set; } // hh:MM

        /// <summary>
        /// The subject of the scheduled class
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// The full name of the teacher of the scheduled class
        /// </summary>
        public string TeacherFullName { get; set; }

        /// <summary>
        /// The starting day of the week of the scheduled class
        /// </summary>
        public DateTime StartingDay { get; set; } // mm/dd/yyyy hh:MM:ss tt
    }
}