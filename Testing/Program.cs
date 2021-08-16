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
            var client = await WizemenClient.NewClientAsync(JsonConvert.DeserializeObject<Credentials>(await File.ReadAllTextAsync("config.json")));
            Console.WriteLine(JsonConvert.SerializeObject(await client.GetClassTeacherAsync(11673), Formatting.Indented));
        }
    }
}