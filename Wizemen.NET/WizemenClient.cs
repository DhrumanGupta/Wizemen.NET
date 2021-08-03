using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Wizemen.NET.Dtos;
using Wizemen.NET.Models;

namespace Wizemen.NET
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
        /// Creates a client used to interact with the API
        /// </summary>
        /// <param name="credentials">The credentials object with the user's credentials</param>
        public WizemenClient(Credentials credentials)
        {
            _credentials = credentials;
            _api = new Api(credentials);
        }

        /// <summary>
        /// Login, generate a cookie, and verify the cookie to enable access to the API.
        /// </summary>
        public async Task StartAsync()
        {
            _endTime = DateTime.Now.AddHours(1);
            await RefreshAsync();
        }

        private async Task RefreshAsync()
        {
            await _api.Login();
            var data = await _api.Request("/generaldata.asmx/openPortal",
                new {portalCode = "WIZPOR6", schoolName = _credentials.SchoolName});

            var link =
                // ReSharper disable once PossibleNullReferenceException
                JsonConvert.DeserializeObject<dynamic>(await data.Content.ReadAsStringAsync()).d.ToString();

            await _api.Request(link, null, HttpMethod.Get, true);
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
                {MeetingType.Zoom, "/classes/student/VirtualClassZoomStudent.aspx/getScheduledMeetings"},
                {MeetingType.Teams, "/classes/student/VirtualClassTeamsStudent.aspx/getScheduledMeetings"}
            };

            var data = await GetDataAsync(linkByPath[meetingType]);
            var meetings = JsonConvert.DeserializeObject<DtoRoot<MeetingDto>>(data)
                           ?? new DtoRoot<MeetingDto>();
            return meetings.D.Select(Meeting.FromDto).ToList();
        }

        /// <summary>
        /// Gets the classes of the authenticated user
        /// </summary>
        /// <returns>The classes found. Returns an empty list if none were found</returns>
        public async Task<List<Class>> GetClassesAsync()
        {
            await RefreshIfNeededAsync();
            const string path = "/classes/student/allclasses.aspx/getClassList";
            var data = await GetDataAsync(path);
            var classes = JsonConvert.DeserializeObject<DtoRoot<ClassDto>>(data)
                          ?? new DtoRoot<ClassDto>();

            return classes.D.Select(Class.FromDto).ToList();
        }

        /// <summary>
        /// Returns a list of all the students in a class
        /// </summary>
        /// <param name="classId">The classId to get the students in</param>
        /// <returns>A list of the students found. Returns an empty list if none were found (invalid classId)</returns>
        public async Task<List<Student>> GetClassListAsync(string classId)
        {
            await _api.Request("/classes/student/studenthomeold.aspx/setclasssession",
                new
                {
                    class_id = classId, classname = ""
                });

            var data = await _api.Request("/classes/faculty/facultyclassroster.aspx/showclasslist",
                new {menuid = ""});

            var students = JsonConvert.DeserializeObject<DtoRoot<Student>>(await data.Content.ReadAsStringAsync())
                           ?? new DtoRoot<Student>();

            return students.D;
        }

        /// <summary>
        /// Gets the events of the authenticated user
        /// </summary>
        /// <returns>The events found. Returns an empty list if none were found</returns>
        public async Task<List<Event>> GetEventsAsync()
        {
            await RefreshIfNeededAsync();
            const string path = "/classes/student/studentclasscalendar.aspx/getEvents";

            var response = await _api.Request(path, new {movdir = "Current"});

            var data = await response.Content.ReadAsStringAsync();
            var events = JsonConvert.DeserializeObject<DtoRoot<EventDto>>(data)
                         ?? new DtoRoot<EventDto>();

            return events.D.Select(Event.FromDto).ToList();
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