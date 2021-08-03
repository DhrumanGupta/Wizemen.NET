using System.Collections.Generic;
using Newtonsoft.Json;

namespace Wizemen.NET.Dtos
{
    internal class DtoRoot<T>
    {
        [JsonProperty("d")] 
        public List<T> D { get; set; }

        public DtoRoot()
        {
            D = new List<T>();
        }
    }
}