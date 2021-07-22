using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            var client = new WizemenClient(credentials);

            await client.Start();
            await TestClasses(client);
        }

        private static async Task TestClasses(WizemenClient client)
        {
            var classes = await client.GetClasses();
            foreach (var c in classes)
            {
                Console.WriteLine($"{c.Course}");
            }
        }

        private static async Task TestMeetings(WizemenClient client)
        {
            var meetings = await client.GetMeetings();
            
            var currTime = new DateTime(2021, 7, 22, 8, 25, 0);
            var uniDay = currTime.DayOfYear;
            
            meetings = meetings
                .Where(meeting => meeting.StartTime.DayOfYear == uniDay)
                .ToList();
            
            Console.WriteLine($"Found {meetings.Count} meetings");
            
            
            var finalMeetings = (from meeting in meetings
                let minutesDiff = (currTime - meeting.StartTime).TotalMinutes
                where minutesDiff < meeting.Duration - 10 && minutesDiff >= -5
                select meeting).ToList();
            
            switch (finalMeetings.Count)
            {
                case < 0:
                    Console.WriteLine("No meetings found");
                    break;
                
                case 1:
                {
                    var m = finalMeetings[0];
                    Console.WriteLine($"{m.Topic}, {m.Host}\n{m.Agenda}\n{m.JoinUrl}\nId: {m.Id}\nPassword: {m.Password}");
                    break;
                }
            }
        }
    }
}