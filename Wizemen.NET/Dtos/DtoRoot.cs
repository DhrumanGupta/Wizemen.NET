using System.Collections.Generic;
using Newtonsoft.Json;

namespace Wizemen.NET.Dtos
{
    internal class DtoRootMultiple<T>
    {
        [JsonProperty("d")] 
        public List<T> Content { get; set; }

        public DtoRootMultiple()
        {
            Content = new List<T>();
        }
    }

    internal class DtoRootSingle<T>
    {
        [JsonProperty("d")] public T Content { get; set; }

        public DtoRootSingle()
        {
            Content = default;
        }
    }
}