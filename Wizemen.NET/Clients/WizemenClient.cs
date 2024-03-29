﻿using System;
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
    public class WizemenClient : IDisposable
    {
        private bool _disposed;
        private readonly Api _api;
        private readonly Credentials _credentials;
        private DateTime _cookieEndTime;

        private WizemenClient(Credentials credentials)
        {
            _credentials = credentials;
            _api = new Api(credentials);
        }

        /// <summary>
        /// Destructor for the Client.
        /// </summary>
        ~WizemenClient() => this.Dispose(false);
        
        private async Task StartAsync()
        {
            _cookieEndTime = DateTime.Now.AddHours(1);
            await RefreshAsync();
        }

        private async Task RefreshAsync()
        {
            await _api.Login();
            
            // Over here we open portals we know of in a specific order to allow wizemen endpoints to send data to us for the respective portals
            // Does make sense? No! Its wizemen. They have 3 endpoints for user data, and 2 steps to verify (not 2FA, just 2 steps)
            // a cookie. They use POST to get data, and GET to logout. Never, will it ever make sense.
            var knownPortals = new[] {1, 2, 3, 5, 6, 8, 9, 10};
            var tasks = knownPortals.Select(OpenPortal).ToArray();
            await Task.WhenAll(tasks);
        }

        private async Task OpenPortal(int portalCode)
        {
            var data = await _api.Request("generaldata.asmx/openPortal",
                new {portalCode = $"WIZPOR{portalCode}", schoolName = _credentials.SchoolName});

            if (!data.IsSuccessStatusCode) throw new InvalidCredentialException("Invalid Credentials Provided");

            var link =
                JsonConvert.DeserializeObject<dynamic>(await data.Content.ReadAsStringAsync())?.d.ToString();

            await _api.Request(link!, null, HttpMethod.Get, true);
        }

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
            var meetings = JsonConvert.DeserializeObject<DtoRootMultiple<MeetingDto>>(data)
                           ?? new DtoRootMultiple<MeetingDto>();
            return meetings.Content.Select(MappingService.Mapper.Map<Meeting>).ToList();
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
            var classes = JsonConvert.DeserializeObject<DtoRootMultiple<ClassListDto>>(data)
                          ?? new DtoRootMultiple<ClassListDto>();

            return classes.Content.Select(MappingService.Mapper.Map<Class>).ToList();
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
            var events = JsonConvert.DeserializeObject<DtoRootMultiple<EventDto>>(data)
                         ?? new DtoRootMultiple<EventDto>();

            return events.Content.Select(MappingService.Mapper.Map<Event>).ToList();
        }

        /// <summary>
        /// Returns a list of all the students in a class
        /// </summary>
        /// <param name="classId">The classId to get the students in</param>
        /// <returns>A list of the students found. Returns an empty list if none were found (invalid classId)</returns>
        public async Task<List<Student>> GetStudentsInClass(int classId)
        {
            await RefreshIfNeededAsync();
            await _api.Request("classes/student/studenthomeold.aspx/setclasssession",
                new
                {
                    class_id = classId.ToString(), classname = ""
                });

            var data = await _api.Request("classes/faculty/facultyclassroster.aspx/showclasslist",
                new {menuid = ""});

            var students =
                JsonConvert.DeserializeObject<DtoRootMultiple<StudentDto>>(await data.Content.ReadAsStringAsync())
                ?? new DtoRootMultiple<StudentDto>();

            return students.Content.Select(MappingService.Mapper.Map<Student>).ToList();
        }

        /// <summary>
        /// Gets information for the provided classId.
        /// </summary>
        /// <remarks>
        /// This uses an endpoint that returns only the Class Id, Name, Code and Grade.
        /// If you are not worried about over-fetching and the authenticated user is in the class responding to the classId,
        /// use <see cref="GetClassesAsync">GetClassesAsync</see> and then filter by ID to get more details.</remarks>
        /// <param name="classId">The classId to get the info of</param>
        /// <returns>A the class object. Returns null if not found (invalid classId)</returns>
        public async Task<Class> GetClass(int classId)
        {
            await RefreshIfNeededAsync();
            await _api.Request("classes/student/studenthomeold.aspx/setclasssession",
                new
                {
                    class_id = classId.ToString(), classname = ""
                });

            var data = await _api.Request("classes/student/studenthomeold.aspx/getclasscode", new { });

            var classObj =
                JsonConvert.DeserializeObject<DtoRootSingle<ClassSingleDto>>(await data.Content.ReadAsStringAsync()) ??
                new DtoRootSingle<ClassSingleDto>();

            return MappingService.Mapper.Map<Class>(classObj.Content);
        }

        /// <summary>
        /// Gets the teacher for the given class Id
        /// </summary>
        /// <param name="classId">The classId that represents the class</param>
        /// <returns>The teacher found. Returns null if not found (invalid classId)</returns>
        public async Task<Teacher> GetClassTeacherAsync(int classId)
        {
            await RefreshIfNeededAsync();
            await _api.Request("classes/student/studenthomeold.aspx/setclasssession",
                new {class_id = classId.ToString(), classname = ""});

            var data = await _api.Request("classes/student/studentclassroster.aspx/getteacherdetail", new { });

            var x = await data.Content.ReadAsStringAsync();

            var students =
                JsonConvert.DeserializeObject<DtoRootMultiple<TeacherDto>>(x)
                ?? new DtoRootMultiple<TeacherDto>();

            if (students.Content.Count <= 0) return null;
            var teacher = MappingService.Mapper.Map<Teacher>(students.Content[0]);
            teacher.ImagePath = $"https://{_credentials.SchoolCode}.wizemen.net{teacher.ImagePath}";
            return teacher;
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

            var students = JsonConvert.DeserializeObject<DtoRootMultiple<ClassAttendanceDto>>(data)
                           ?? new DtoRootMultiple<ClassAttendanceDto>();

            return students.Content.Select(MappingService.Mapper.Map<ClassAttendance>).ToList();
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
                        data.IndexOf(imperfectFilter, StringComparison.InvariantCultureIgnoreCase) +
                        imperfectFilter.Length,
                        3)
                    .Split('/')[0];

            if (!int.TryParse(imperfectData, out int imperfectDays)) return null;

            return new MasterAttendance
                {TotalDays = totalDays, Absent = absentDays, Imperfect = imperfectDays, Present = presentDays};
        }

        /// <summary>
        /// Gets the class schedule on wizemen for the current week
        /// </summary>
        /// <returns>The class schedule found</returns>
        public async Task<List<ClassSchedule>> GetClassScheduleAsync()
        {
            await RefreshIfNeededAsync();
            var response = await _api.Request("classes/generaldata.asmx/LoadClassScheduleNew",
                new
                {
                    Counter = 0, week = "currentweek"
                });

            var x = await response.Content.ReadAsStringAsync();
            var students = JsonConvert.DeserializeObject<DtoRootMultiple<ClassScheduleDto>>(x)
                           ?? new DtoRootMultiple<ClassScheduleDto>();
            return students.Content.Select(MappingService.Mapper.Map<ClassSchedule>).ToList();
        }


        /// <summary>
        /// Disposes the client. Safely disposes all resources used in order to prevent memory leaks
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Disposes the objects.
        /// </summary>
        /// <param name="disposing">States whether the object is current being disposed</param>
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                _api?.Dispose();
            }

            _disposed = true;
        }

        #region Helpers

        private async Task<string> GetDataAsync(string path)
        {
            var response = await _api.Request(path, new { });
            return await response.Content.ReadAsStringAsync();
        }

        private async Task RefreshIfNeededAsync()
        {
            if (DateTime.Now > _cookieEndTime)
            {
                await RefreshAsync();
            }
        }

        #endregion
    }
}