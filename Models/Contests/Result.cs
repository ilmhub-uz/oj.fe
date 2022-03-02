using Newtonsoft.Json;
namespace oj.fe.Models.Contests;

public class Result
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("created_by")]
    public CreatedBy CreatedBy { get; set; }

    [JsonProperty("status")]
    public string Status { get; set; }

    [JsonProperty("contest_type")]
    public string ContestType { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("real_time_rank")]
    public bool RealTimeRank { get; set; }

    [JsonProperty("rule_type")]
    public string RuleType { get; set; }

    [JsonProperty("start_time")]
    public DateTime StartTime { get; set; }

    [JsonProperty("end_time")]
    public DateTime EndTime { get; set; }

    [JsonProperty("create_time")]
    public DateTime CreateTime { get; set; }

    [JsonProperty("last_update_time")]
    public DateTime LastUpdateTime { get; set; }
}

