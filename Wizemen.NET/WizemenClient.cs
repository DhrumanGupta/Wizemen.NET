using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Wizemen.NET.DtoModels;
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
                new Dictionary<string, string>
                {
                    {"portalCode", "WIZPOR6"},
                    {"schoolName", _credentials.SchoolName}
                });


            var link =
                // ReSharper disable once PossibleNullReferenceException
                JsonConvert.DeserializeObject<dynamic>(await data.Content.ReadAsStringAsync()).d.ToString();

            await _api.Request(link, null, HttpMethod.Get, true);
        }

        /// <summary>
        /// Gets the meetings for the authenticated user
        /// </summary>
        /// <returns>The meetings found. Returns an empty list if none were found</returns>
        public async Task<List<Meeting>> GetMeetingsAsync()
        {
            await RefreshIfNeededAsync();
            const string path = "/classes/student/VirtualClassZoomStudent.aspx/getScheduledMeetings";
            var data = await GetDataAsync(path);
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
        /// Gets the events of the authenticated user
        /// </summary>
        /// <returns>The events found. Returns an empty list if none were found</returns>
        public async Task<List<Event>> GetEventsAsync()
        {
            await RefreshIfNeededAsync();
            const string path = "/classes/student/studentclasscalendar.aspx/getEvents";
            
            var response = await _api.Request(path, new Dictionary<string, string>()
            {
                {"movdir", "Current"}
            });
            
            var data = await response.Content.ReadAsStringAsync();
            var events = JsonConvert.DeserializeObject<DtoRoot<EventDto>>(data)
                          ?? new DtoRoot<EventDto>();

            return events.D.Select(Event.FromDto).ToList();
        }

        #region Helpers

        private async Task<string> GetDataAsync(string path)
        {
            var response = await _api.Request(path, new Dictionary<string, string>());
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