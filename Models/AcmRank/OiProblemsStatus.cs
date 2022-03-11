using System.Text.Json.Serialization;

namespace oj.fe.Models.AcmRank;

public class OiProblemsStatus
    {
        [JsonPropertyName("problems")]
        public Problems Problems { get; set; }

        [JsonPropertyName("contest_problems")]
        public ContestProblems ContestProblems { get; set; }
    }

