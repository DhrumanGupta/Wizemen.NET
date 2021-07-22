using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;
using Wizemen.NET.Models;

namespace Wizemen.NET
{
    internal class Api
    {
        private readonly CookieContainer _cookies = new();

        private readonly HttpClient _client;
        
        private readonly Credentials _credentials;
        private readonly string _fullLink;

        internal Api(Credentials credentials)
        {
            var handler = new HttpClientHandler {CookieContainer = _cookies, UseCookies = true};
            _client = new HttpClient(handler);

            _credentials = credentials;
            _fullLink = $"{credentials.SchoolCode.ToString().ToLower()}.wizemen.net";

            var link = $"https://{_fullLink}";
            _client.BaseAddress = new Uri(link);
            _client.DefaultRequestHeaders.Add("Accept", "application/json, text/javascript, */*; q=0.01");
            _client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br");
            _client.DefaultRequestHeaders.Add("Host", _fullLink);
            _client.DefaultRequestHeaders.Add("Origin", link);
            _client.DefaultRequestHeaders.Add("User-Agent",
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.164 Safari/537.36");
            _client.DefaultRequestHeaders.Add("X-Requested-With", "XMLHttpRequest");
        }
        
#nullable enable
        internal async Task<HttpResponseMessage> Request(string path,
            object? content = null, HttpMethod? method = null, bool ignoreContent =false)
        {
            method ??= HttpMethod.Post;
            var data = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json");

            var message = new HttpRequestMessage
            {
                Method = method,
                RequestUri = new Uri($"{_client.BaseAddress}{path}")
            };

            if (!ignoreContent)
            {
                message.Content = data;
            }
            

            var request = await _client.SendAsync(message);
            return request;
        }

#nullable disable

        internal async Task Login()
        {
            var errors = new[]
            {
                "Incorrect Password Entered.",
                "This Email ID is not registered with Wizemen."
            };

            var request = await Request("/homecontrollers/login/validateUser",
                new Dictionary<string, string>
                {
                    {"emailid", _credentials.Email},
                    {"pwd", _credentials.Password},
                    {"schoolCode", _credentials.SchoolCode.ToString().ToUpper()}
                });

            var content = await request.Content.ReadAsStringAsync();

            if (errors.Contains(content, StringComparer.InvariantCultureIgnoreCase))
            {
                throw new InvalidCredentialException(content);
            }
        }
    }
}