using System.Text.Json.Serialization;

namespace oj.fe.Models.AcmRank;

public class AcmRankModels
    {
        [JsonPropertyName("error")]
        public object Error { get; set; }

        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }

