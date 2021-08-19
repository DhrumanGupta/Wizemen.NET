using System;
using System.Net;
using System.Net.Http;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Wizemen.NET.Models;

namespace Wizemen.NET.Clients
{
    internal class Api : IDisposable
    {
        private bool _disposed = false;
        private readonly CookieContainer _cookies = new();

        private readonly HttpClient _client;

        private readonly Credentials _credentials;
        private readonly string _domainLink;

        internal Api(Credentials credentials)
        {
            var handler = new HttpClientHandler {CookieContainer = _cookies, UseCookies = true};
            _client = new HttpClient(handler);

            _credentials = credentials;
            _domainLink = $"{credentials.SchoolCode.ToString().ToLower()}.wizemen.net";

            _client.BaseAddress = new Uri($"https://{_domainLink}");
        }

        ~Api() => this.Dispose(false);

#nullable enable
        internal async Task<HttpResponseMessage> Request(string path,
            object? content = null, HttpMethod? method = null, bool ignoreContent = false)
        {
            method ??= HttpMethod.Post;
            var data = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json");

            var message = new HttpRequestMessage
            {
                Method = method,
                RequestUri = new Uri($"{_client.BaseAddress}{path}"),
                Headers =
                {
                    {"Accept", "application/json, text/javascript, */*; q=0.01"},
                    {"Accept-Encoding", "gzip, deflate, br"},
                    {"Host", _domainLink},
                    {"Origin", _client.BaseAddress?.ToString()},
                    {
                        "User-Agent",
                        "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.164 Safari/537.36"
                    },
                    {"X-Requested-With", "XMLHttpRequest"}
                }
            };

            if (!ignoreContent)
            {
                message.Content = data;
            }

            var request = await _client.SendAsync(message);

            return request;
        }

        internal async Task<string> RequestHtml(string path)
        {
            var request = await _client.GetStringAsync($"{_client.BaseAddress}{path}");
            return request;
        }

#nullable disable

        internal async Task Login()
        {
            var request = await Request("homecontrollers/login/validateUser",
                new
                {
                    emailid = _credentials.Email,
                    pwd = _credentials.Password,
                    schoolCode = _credentials.SchoolCode.ToString().ToUpper(),
                    schoolName = _credentials.SchoolName
                });

            var content = await request.Content.ReadAsStringAsync();

            if (!content.Contains("success_student", StringComparison.InvariantCultureIgnoreCase))
            {
                throw new InvalidCredentialException(content);
            }
        }

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                _client?.Dispose();
            }
            _disposed = true;
        }
    }
}