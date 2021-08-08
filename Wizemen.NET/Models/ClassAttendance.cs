namespace Wizemen.NET.Models
{
    /// <summary>
    /// Attendance data for a class
    /// </summary>
    public class ClassAttendance
    {
        /// <summary>
        /// The subject the attendance is regarding
        /// </summary>
        public string Subject { get; set; }
        
        /// <summary>
        /// The subject's teacher's full name
        /// </summary>
        public string TeacherFullName { get; set; }
        
        /// <summary>
        /// Total No. of classes conducted for the subject
        /// </summary>
        public int TotalClasses { get; set; }
        
        /// <summary>
        /// No. of classes the student was marked present for.
        /// <remarks>Teachers usually mark students <see cref="PresentInClass">Present in Class</see> or <see cref="PresentOnline">Present Online</see></remarks>
        /// </summary>
        public int Present { get; set; }
        
        /// <summary>
        /// No. of classes the student was marked as Present In Class
        /// </summary>
        public int PresentInClass { get; set; }

        /// <summary>
        /// No. of classes the student was marked as Present Online
        /// </summary>
        public int PresentOnline { get; set; }

        /// <summary>
        /// No. of classes the student was marked as Absent Unexcused
        /// </summary>
        public int AbsentUnexcused { get; set; }

        /// <summary>
        /// No. of classes the student was marked as Absent Excused
        /// </summary>
        public int AbsentExcused { get; set; }

        /// <summary>
        /// No. of classes the student was marked absent for Illness
        /// </summary>
        public int StudentIllness { get; set; }

        /// <summary>
        /// No. of classes the student was marked absent for being Sent Home
        /// </summary>
        public int SentHome { get; set; }

        /// <summary>
        /// No. of classes the student was marked Exeat
        /// </summary>
        public int Exeat { get; set; }

        /// <summary>
        /// No. of classes the student was marked Late Unexcused
        /// </summary>
        public int LateUnexcused { get; set; }

        /// <summary>
        /// No. of classes the student was marked Late Excused
        /// </summary>
        public int LateExcused { get; set; }

        /// <summary>
        /// No. of classes the student was marked Not Expected
        /// </summary>
        public int NotExpected { get; set; }

        /// <summary>
        /// No. of classes the student was marked for Early Dismissal
        /// </summary>
        public int EarlyDismissal { get; set; }


        /// <summary>
        /// No. of classes the student was marked for School Tri[
        /// </summary>
        public int SchoolTrip { get; set; }


        /// <summary>
        /// No. of classes the student was marked for Representing School
        /// </summary>
        public int RepresentingSchool { get; set; }

        /// <summary>
        /// No. of classes the student was marked for Exam Leave
        /// </summary>
        public int ExamLeave { get; set; }

        /// <summary>
        /// No. of classes the student was marked for ALS
        /// </summary>
        public int Als { get; set; }


        /// <summary>
        /// No. of classes the student was marked Suspended
        /// </summary>
        public int Suspended { get; set; }
    }
}