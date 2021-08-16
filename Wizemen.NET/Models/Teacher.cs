namespace Wizemen.NET.Models
{
    /// <summary>
    /// Represents a class's teacher
    /// </summary>
    public class Teacher
    {
        /// <summary>
        /// The full name of the teacher
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// The school provided email of the teacher
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The phone number of the teacher (possibly null)
        /// </summary>
        public string PhoneNumber { get; set; }
        
        /// <summary>
        /// The url to the teacher's image
        /// </summary>
        public string ImagePath { get; set; }
        
        /// <summary>
        /// The teacher's job designation
        /// </summary>
        public string Designation { get; set; }
    }
}