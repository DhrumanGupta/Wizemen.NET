using Newtonsoft.Json;

namespace Wizemen.NET.Dtos
{
    internal class ClassSingleDto
    {
        [JsonProperty("class_id")] public int Id { get; set; }

        [JsonProperty("class_name")] public string Name { get; set; }

        [JsonProperty("classcode")] public string Code { get; set; }

        [JsonProperty("grade")] public string Grade { get; set; }
    }
}