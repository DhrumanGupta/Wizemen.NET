using Newtonsoft.Json;

namespace Wizemen.NET.Dtos
{
    internal class TeacherDto
    {
        [JsonProperty("formtutor_name")] public string Name { get; set; }
        [JsonProperty("formtutor_mail")] public string Email { get; set; }
        [JsonProperty("formtutor_phone")] public string PhoneNumber { get; set; }
        [JsonProperty("formtutor_img")] public string ImagePath { get; set; }
        [JsonProperty("formtutor_designation")] public string Designation { get; set; }
    }
}