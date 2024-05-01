using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace _Backend.DataModel
{
    public class LocationOfInterest
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("exposure_events")]
        public IList<ExposureEvent> ExposureEvents { get; set; }
    }

    public class ExposureEvent
    {
        [JsonProperty("day")]
        public string Day { get; set; }

        [JsonProperty("times")]
        public string Times { get; set; }
    }
}
