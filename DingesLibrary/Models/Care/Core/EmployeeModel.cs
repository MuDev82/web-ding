using Newtonsoft.Json;
using System.Collections.Generic;

namespace DingesLibrary.Models.Care.Core
{
    public class EmployeeModel
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("EmployeeId")]
        public string EmployeeId { get; set; }

        [JsonProperty("AuthorizedClients")]
        public IList<string> AuthorizedClients { get; set; }
    }
}
