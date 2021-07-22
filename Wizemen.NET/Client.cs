using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Wizemen.NET.Models;

namespace Wizemen.NET
{
    /// <summary>
    /// Client class used to interact with the API.
    /// </summary>
    public class Client
    {
        private readonly Api _api;
        private readonly Credentials _credentials;

        /// <summary>
        /// Creates a client used to interact with the API
        /// </summary>
        /// <param name="credentials">The credentials object with the user's credentials</param>
        public Client(Credentials credentials)
        {
            _credentials = credentials;
            _api = new Api(credentials);
        }

        public async Task Start()
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

        public async Task<Meeting[]> GetMeetings()
        {
            const string path = "/classes/student/VirtualClassZoomStudent.aspx/getScheduledMeetings";
            var response = await _api.Request(path, new Dictionary<string, string>());
            var data = await response.Content.ReadAsStringAsync();
            var meetings = JsonConvert.DeserializeObject<MeetingsDTO>(data) ?? new MeetingsDTO();
            return meetings.D;
        }
    }
}