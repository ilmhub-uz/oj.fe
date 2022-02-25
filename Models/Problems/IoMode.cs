using Newtonsoft.Json;

namespace oj.fe.Models.Problems;

public class IoMode
    {
        [JsonProperty("input")]
        public string Input { get; set; }

        [JsonProperty("output")]
        public string Output { get; set; }

        [JsonProperty("io_mode")]
        public string Io_Mode { get; set; }
    }

