using Newtonsoft.Json;
using System;

namespace DingesLibrary.Models.Care.Core
{
    public class ClientModel
    {
        [JsonProperty("FirstName")]
        public string FirstName { get; set; }

        [JsonProperty("LastName")]
        public string LastName { get; set; }

        [JsonProperty("BirthDate")]
        public DateTime BirthDate { get; set; }

        [JsonProperty("Gender")]
        public string Gender { get; set; }

        [JsonProperty("NativeId")]
        public string NativeId { get; set; }
    }
}
