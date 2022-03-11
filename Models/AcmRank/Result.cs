using System.Text.Json.Serialization;

namespace oj.fe.Models.AcmRank;

public class Result
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("user")]
        public User User { get; set; }

        [JsonPropertyName("acm_problems_status")]
        public AcmProblemsStatus AcmProblemsStatus { get; set; }

        [JsonPropertyName("oi_problems_status")]
        public OiProblemsStatus OiProblemsStatus { get; set; }

        [JsonPropertyName("real_name")]
        public string RealName { get; set; }

        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }

        [JsonPropertyName("blog")]
        public string Blog { get; set; }

        [JsonPropertyName("mood")]
        public string Mood { get; set; }

        [JsonPropertyName("github")]
        public string Github { get; set; }

        [JsonPropertyName("school")]
        public string School { get; set; }

        [JsonPropertyName("major")]
        public string Major { get; set; }

        [JsonPropertyName("language")]
        public string Language { get; set; }

        [JsonPropertyName("accepted_number")]
        public int AcceptedNumber { get; set; }

        [JsonPropertyName("total_score")]
        public int TotalScore { get; set; }

        [JsonPropertyName("submission_number")]
        public int SubmissionNumber { get; set; }
    }

