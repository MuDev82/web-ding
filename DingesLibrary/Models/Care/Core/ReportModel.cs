using Newtonsoft.Json;
using System;

namespace DingesLibrary.Models.Care.Core
{
    public class ReportModel
    {
        [JsonProperty("Subject")]
        public string Subject { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }

        [JsonProperty("HasPriority")]
        public bool HasPriority { get; set; }

        [JsonProperty("CarePlanGoalId")]
        public string CarePlanGoalId { get; set; }

        [JsonProperty("ClientId")]
        public string ClientId { get; set; }

        [JsonProperty("CreatedBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("CreatedAt")]
        public DateTime CreatedAt { get; set; }
    }
}
