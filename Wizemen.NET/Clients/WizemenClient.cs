using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Authentication;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Wizemen.NET.Dtos;
using Wizemen.NET.Models;
using Wizemen.NET.Services;

namespace Wizemen.NET.Clients
{
    /// <summary>
    /// Client class used to interact with the API.
    /// </summary>
    public class WizemenClient
    {
        private readonly Api _api;
        private readonly Credentials _credentials;
        private DateTime _endTime;

        /// <summary>
        /// Creates a client used to interact with the API asynchronously
        /// </summary>
        /// <param name="credentials">The credentials object with the user's credentials</param>
        /// <exception cref="InvalidCredentialException">Thrown if the credentials provided were invalid</exception>
        public static async Task<WizemenClient> NewClientAsync(Credentials credentials)
        {
            var client = new WizemenClient(credentials);
            await client.StartAsync();
            return client;
        }
        
        private WizemenClient(Credentials credentials)
        {
            _credentials = credentials;
            _api = new Api(credentials);
        }
        
        private async Task StartAsync()
        {
            _endTime = DateTime.Now.AddHours(1);
            await RefreshAsync();
        }

        private async Task RefreshAsync()
        {
            await _api.Login();

            var data = await _api.Request("generaldata.asmx/openPortal",
                new {portalCode = "WIZPOR6", schoolName = _credentials.SchoolName});

            var link =
                JsonConvert.DeserializeObject<dynamic>(await data.Content.ReadAsStringAsync())?.d.ToString();

            await _api.Request(link!, null, HttpMethod.Get, true);
        }

        /// <summary>
        /// Gets the meetings for the authenticated user
        /// </summary>
        /// <param name="meetingType">The type of meeting to get</param>
        /// <returns>The meetings found. Returns an empty list if none were found</returns>
        public async Task<List<Meeting>> GetMeetingsAsync(MeetingType meetingType)
        {
            await RefreshIfNeededAsync();
            var linkByPath = new Dictionary<MeetingType, string>
            {
                {MeetingType.Zoom, "classes/student/VirtualClassZoomStudent.aspx/getScheduledMeetings"},
                {MeetingType.Teams, "classes/student/VirtualClassTeamsStudent.aspx/getScheduledMeetings"}
            };
            var data = await GetDataAsync(linkByPath[meetingType]);
            var meetings = JsonConvert.DeserializeObject<DtoRoot<MeetingDto>>(data)
                           ?? new DtoRoot<MeetingDto>();
            return meetings.D.Select(Mapping.Mapper.Map<Meeting>).ToList();
        }

        /// <summary>
        /// Gets the classes of the authenticated user
        /// </summary>
        /// <returns>The classes found. Returns an empty list if none were found</returns>
        public async Task<List<Class>> GetClassesAsync()
        {
            await RefreshIfNeededAsync();
            const string path = "classes/student/allclasses.aspx/getClassList";
            var data = await GetDataAsync(path);
            var classes = JsonConvert.DeserializeObject<DtoRoot<ClassDto>>(data)
                          ?? new DtoRoot<ClassDto>();

            return classes.D.Select(Mapping.Mapper.Map<Class>).ToList();
        }

        /// <summary>
        /// Gets the events of the authenticated user
        /// </summary>
        /// <returns>The events found. Returns an empty list if none were found</returns>
        public async Task<List<Event>> GetEventsAsync()
        {
            await RefreshIfNeededAsync();
            const string path = "classes/student/studentclasscalendar.aspx/getEvents";

            var response = await _api.Request(path, new {movdir = "Current"});

            var data = await response.Content.ReadAsStringAsync();
            var events = JsonConvert.DeserializeObject<DtoRoot<EventDto>>(data)
                         ?? new DtoRoot<EventDto>();

            return events.D.Select(x => x.ToObject()).ToList();
        }

        /// <summary>
        /// Returns a list of all the students in a class
        /// </summary>
        /// <param name="classId">The classId to get the students in</param>
        /// <returns>A list of the students found. Returns an empty list if none were found (invalid classId)</returns>
        public async Task<List<Student>> GetClassListAsync(int classId)
        {
            await RefreshIfNeededAsync();
            await _api.Request("classes/student/studenthomeold.aspx/setclasssession",
                new
                {
                    class_id = classId.ToString(), classname = ""
                });

            var data = await _api.Request("classes/faculty/facultyclassroster.aspx/showclasslist",
                new {menuid = ""});

            var students = JsonConvert.DeserializeObject<DtoRoot<StudentDto>>(await data.Content.ReadAsStringAsync())
                           ?? new DtoRoot<StudentDto>();

            return students.D.Select(Mapping.Mapper.Map<Student>).ToList();
        }

        /// <summary>
        /// Returns the attendance status for all classes of an authenticated user
        /// </summary>
        /// <returns>The attendance list found. Returns null if not found (unauthorized or server error)</returns>
        public async Task<List<ClassAttendance>> GetAttendanceStatusAsync()
        {
            await RefreshIfNeededAsync();
            var data =
                await GetDataAsync("classes/student/studentattendance.aspx/getAttendanceStatus");
            
            var students = JsonConvert.DeserializeObject<DtoRoot<ClassAttendanceDto>>(data)
                           ?? new DtoRoot<ClassAttendanceDto>();

            return students.D.Select(Mapping.Mapper.Map<ClassAttendance>).ToList();
        }

        /// <summary>
        /// Gets the master attendance (not specific to any subject) for the authenticated user
        /// </summary>
        /// <returns>The master attendance object found. Returns null if data was not found</returns>
        public async Task<MasterAttendance> GetMasterAttendanceAsync()
        {
            await RefreshIfNeededAsync();
            var data = await _api.RequestHtml("launchpadnew");
            const string presentFilter = "Present:&nbsp;";
            const string absentFilter = "Absent:&nbsp;";
            const string imperfectFilter = "Imperfect:&nbsp;";

            var presentString =
                data.Substring(
                    data.IndexOf(presentFilter, StringComparison.InvariantCultureIgnoreCase) + presentFilter.Length, 7);
            var presentData = presentString.Split('<')[0].Split('/');

            if (!int.TryParse(presentData.Last(), out int totalDays)) return null;
            if (!int.TryParse(presentData[0], out int presentDays)) return null;

            var absentData =
                data.Substring(
                        data.IndexOf(absentFilter, StringComparison.InvariantCultureIgnoreCase) + absentFilter.Length,
                        3)
                    .Split('/')[0];

            if (!int.TryParse(absentData, out int absentDays)) return null;

            var imperfectData =
                data.Substring(
                        data.IndexOf(imperfectFilter, StringComparison.InvariantCultureIgnoreCase) + imperfectFilter.Length,
                        3)
                    .Split('/')[0];

            if (!int.TryParse(imperfectData, out int imperfectDays)) return null;
            
            return new MasterAttendance{TotalDays = totalDays,  Absent = absentDays, Imperfect = imperfectDays, Present = presentDays};
        }
        
        #region Helpers

        private async Task<string> GetDataAsync(string path)
        {
            var response = await _api.Request(path, new { });
            return await response.Content.ReadAsStringAsync();
        }

        private async Task RefreshIfNeededAsync()
        {
            if (DateTime.Now > _endTime)
            {
                await RefreshAsync();
            }
        }

        #endregion
    }
}