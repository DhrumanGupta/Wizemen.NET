﻿using System;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Wizemen.NET;
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
            var client = new WizemenClient(JsonConvert.DeserializeObject<Credentials>(await File.ReadAllTextAsync("config.json")));
            await client.StartAsync();

            var list = await client.GetClassListAsync("11447");
            foreach (var entity in list)
            {
                Console.WriteLine($"{entity.FirstName} {entity.LastName}, {entity.StudentEmail}");
            }
        }
    }
}