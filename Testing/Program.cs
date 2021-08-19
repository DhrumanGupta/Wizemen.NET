using System;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Wizemen.NET.Clients;
using Wizemen.NET.Models;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Async().GetAwaiter().GetResult();
        }

        private static async Task Async()
        {
            var credentials = JsonConvert.DeserializeObject<Credentials>(await File.ReadAllTextAsync("config.json"));
            var client = await WizemenClient.NewClientAsync(credentials);
            Console.WriteLine(JsonConvert.SerializeObject(await client.GetMeetingsAsync(MeetingType.Zoom), Formatting.Indented));
        }
    }
}