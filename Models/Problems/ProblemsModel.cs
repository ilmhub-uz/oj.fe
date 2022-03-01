using Newtonsoft.Json;

namespace oj.fe.Models.Problems;

public class ProblemsModel
    {
        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Problems Data { get; set; }
    }

