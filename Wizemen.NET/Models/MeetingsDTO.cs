using Newtonsoft.Json;

namespace Wizemen.NET.Models
{
    public class MeetingsDTO
    {
        [JsonProperty("d")]
        public Meeting[] D { get; set; }
    }
}