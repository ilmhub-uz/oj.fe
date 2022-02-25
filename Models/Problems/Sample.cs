using Newtonsoft.Json;

namespace oj.fe.Models.Problems;

public class Sample
    {
        [JsonProperty("input")]
        public string Input { get; set; }

        [JsonProperty("output")]
        public string Output { get; set; }
    }

