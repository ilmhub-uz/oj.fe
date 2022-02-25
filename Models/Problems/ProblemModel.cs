using Newtonsoft.Json;

namespace oj.fe.Models.Problems;

public class ProblemModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("created_by")]
        public CreatedBy CreatedBy { get; set; }

        [JsonProperty("template")]
        public Template Template { get; set; }

        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("input_description")]
        public string InputDescription { get; set; }

        [JsonProperty("output_description")]
        public string OutputDescription { get; set; }

        [JsonProperty("samples")]
        public List<Sample> Samples { get; set; }

        [JsonProperty("hint")]
        public string Hint { get; set; }

        [JsonProperty("languages")]
        public List<string> Languages { get; set; }

        [JsonProperty("create_time")]
        public DateTime CreateTime { get; set; }

        [JsonProperty("last_update_time")]
        public object LastUpdateTime { get; set; }

        [JsonProperty("time_limit")]
        public int TimeLimit { get; set; }

        [JsonProperty("memory_limit")]
        public int MemoryLimit { get; set; }

        [JsonProperty("io_mode")]
        public IoMode IoMode { get; set; }

        [JsonProperty("spj")]
        public bool Spj { get; set; }

        [JsonProperty("spj_language")]
        public object SpjLanguage { get; set; }

        [JsonProperty("rule_type")]
        public string RuleType { get; set; }

        [JsonProperty("difficulty")]
        public string Difficulty { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("total_score")]
        public int TotalScore { get; set; }

        [JsonProperty("submission_number")]
        public int SubmissionNumber { get; set; }

        [JsonProperty("accepted_number")]
        public int AcceptedNumber { get; set; }

        [JsonProperty("statistic_info")]
        public StatisticInfo StatisticInfo { get; set; }

        [JsonProperty("share_submission")]
        public bool ShareSubmission { get; set; }

        [JsonProperty("contest")]
        public object Contest { get; set; }
    }

