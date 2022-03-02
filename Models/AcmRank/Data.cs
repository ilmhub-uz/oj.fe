using System.Text.Json.Serialization;

namespace oj.fe.Models.AcmRank;

public class Data
    {
        [JsonPropertyName("results")]
        public List<Result> Results { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }
    }

