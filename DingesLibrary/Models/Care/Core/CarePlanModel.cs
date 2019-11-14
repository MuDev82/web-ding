using Newtonsoft.Json;
using System.Collections.Generic;

namespace DingesLibrary.Models.Care.Core
{
    public class CarePlanModel
    {
        [JsonProperty("Id")]
        public string Id { get; set; }

        [JsonProperty("DisplayName")]
        public string DisplayName { get; set; }

        [JsonProperty("ClientId")]
        public string ClientId { get; set; }

        [JsonProperty("Goals")]
        public IList<Goal> Goals { get; set; }
    }

    public class Goal
    {

        [JsonProperty("DisplayName")]
        public string DisplayName { get; set; }

        [JsonProperty("GoalId")]
        public string GoalId { get; set; }
    }
}
