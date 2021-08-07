namespace Wizemen.NET.Models
{
    /// <summary>
    /// Master attendance for a user
    /// </summary>
    public class MasterAttendance
    {
        /// <summary>
        /// Total days of the attendance
        /// </summary>
        public int TotalDays { get; set; }
        
        /// <summary>
        /// Days the user had a Present attendance
        /// </summary>
        public int Present { get; set; }
        
        /// <summary>
        /// Days the user had an Absent attendance
        /// </summary>
        public int Absent { get; set; }
        
        /// <summary>
        /// Days the user had an Imperfect attendance
        /// </summary>
        public int Imperfect { get; set; }
    }
}