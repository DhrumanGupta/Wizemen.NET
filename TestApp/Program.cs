using System;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Wizemen.NET;
using Wizemen.NET.Models;

namespace TestApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var credentials = JsonConvert.DeserializeObject<Credentials>(await File.ReadAllTextAsync("config.json"));
            var client = new Client(credentials);
            await client.Start();
            await client.GetMeetings();
        }
    }
}